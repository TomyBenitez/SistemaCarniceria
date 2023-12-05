using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Sistema_Carnicería.Data;
using Sistema_Carnicería.Repositories;
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
    public partial class ReporteClientesView : Form
    {
        private ClientesRepository repository = new ClientesRepository();
        ReportViewer reporte = new ReportViewer();
        public ReporteClientesView()
        {
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
        }

        private async void ReporteClientesView_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Sistema_Carnicería.Reports.RptListadoClientes.rdlc";
            var clientes = await repository.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", clientes));
            reporte.RefreshReport();
        }
    }
}
