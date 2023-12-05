using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Sistema_Carnicería.Data;
using Sistema_Carnicería.Models;
using Sistema_Carnicería.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carnicería.Views
{
    public partial class SplashView : Form
    {
        bool ConexionRealizada = false;
        bool ImpresionRealizada = false;
        private CobradoresRepository repository = new CobradoresRepository();
        private CarniceríaContext db = new CarniceríaContext();
        public SplashView()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
        }

        private async void SplashView_Activated(object sender, EventArgs e)
        {
            await ConectarConDb();
            await ImprimirReporte();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 2;
            if (ConexionRealizada && ImpresionRealizada)
            {
                timer.Enabled = false;
                this.Visible = false;
                var homeCarniceríaView = new HomeCarniceríaView();
                homeCarniceríaView.ShowDialog();
                this.Close();
            }
        }

        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                ReportViewer reporte = new ReportViewer();
                reporte.LocalReport.ReportEmbeddedResource = "Sistema_Carnicería.Reports.RptListadoCobradores.rdlc";
                var cobradores = db.Cobradores.OrderBy(c => c.Apellido_Nombre).ToList();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCobrador", cobradores));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;
                reporte.RefreshReport();
                ImpresionRealizada = true;
            });

        }

        private async Task ConectarConDb()
        {
            await Task.Run(async () =>
            {
                await db.Database.CanConnectAsync();
                ConexionRealizada = true;
            });
        }
    }
}
