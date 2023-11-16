using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Sistema_Carnicería.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carnicería.ViewReports
{
    public partial class ReporteVentasView : Form
    {
        CarniceríaContext db = new CarniceríaContext();
        ReportViewer reporte = new ReportViewer();
        public ReporteVentasView()
        {
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
        }

        private async void ReporteProductosView_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Sistema_Carnicería.Reports.RptListadoVentas.rdlc";
            var ventas = await db.Ventas.ToListAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", ventas));
            reporte.RefreshReport();
        }
    }
}
