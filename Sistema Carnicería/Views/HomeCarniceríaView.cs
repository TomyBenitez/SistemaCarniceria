using Sistema_Carnicería.Models;
using Sistema_Carnicería.Presentation;
using Sistema_Carnicería.ViewReports;
using Sistema_Carnicería.Views;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ObjectiveC;

namespace Sistema_Carnicería
{
    public partial class HomeCarniceríaView : Form
    {
        public static Cobrador UsuarioLogueado { get; set; }
        public HomeCarniceríaView()
        {
            InitializeComponent();
            CBModoOscuro.SelectedIndex = 0;
        }

        private void acercaDeSistemaCarniceríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeSistemaView acercadesistemacarnicería = new AcercaDeSistemaView();
            acercadesistemacarnicería.ShowDialog();
        }

        private void salirDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Muestro las Etiquetas y Oculto Etiquetas
        private void mostrarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPrincipal.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            BtnAcercaDe.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            BtnOpciones.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            BtnSalir.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void ocultarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPrincipal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnAcercaDe.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnOpciones.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        //configuro los botones de la barra de herramientas
        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            acercaDeSistemaCarniceríaToolStripMenuItem_Click(sender, e);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            salirDeSistemaToolStripMenuItem_Click(sender, e);
        }

        //Configuro el modo oscuro
        private void CBModoOscuro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBModoOscuro.SelectedIndex == 0)
            {
                this.BackColor = Color.White;
                TextoBarraDeEstado.Text = "Modo Claro";
                TextoBarraDeEstado.ForeColor = Color.Black;
                BarraDeEstado.BackColor = Color.White;
                BarraHerramientas.BackColor = Color.White;
                menuStrip1.BackColor = Color.White;
                BarraHerramientas.BackColor = Color.White;
                menuStrip1.BackColor = Color.White;
                CBModoOscuro.BackColor = Color.White;
                CBModoOscuro.ForeColor = Color.Black;
                mostrarEtiquetasToolStripMenuItem.BackColor = Color.White;
                mostrarEtiquetasToolStripMenuItem.ForeColor = Color.Black;
                ocultarEtiquetasToolStripMenuItem.BackColor = Color.White;
                ocultarEtiquetasToolStripMenuItem.ForeColor = Color.Black;
                BtnPrincipal.ForeColor = Color.Black;
                BtnAcercaDe.ForeColor = Color.Black;
                BtnOpciones.ForeColor = Color.Black;
                BtnSalir.ForeColor = Color.Black;
                principalToolStripMenuItem.ForeColor = Color.Black;
                principalToolStripMenuItem.BackColor = Color.White;
                utilidadesToolStripMenuItem.ForeColor = Color.Black;
                utilidadesToolStripMenuItem.BackColor = Color.White;
                salirToolStripMenuItem.ForeColor = Color.Black;
                salirToolStripMenuItem.BackColor = Color.White;
                //ahora configuro de la barra menu, los contenedores internos
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 18, 18, 18);
                TextoBarraDeEstado.Text = "Modo Oscuro";
                TextoBarraDeEstado.ForeColor = Color.White;
                BarraDeEstado.BackColor = Color.FromArgb(255, 31, 31, 31);
                BarraHerramientas.BackColor = Color.White;
                menuStrip1.BackColor = Color.White;
                BarraHerramientas.BackColor = Color.FromArgb(255, 31, 31, 31);
                menuStrip1.BackColor = Color.FromArgb(255, 31, 31, 31);
                CBModoOscuro.BackColor = Color.FromArgb(255, 31, 31, 31);
                CBModoOscuro.ForeColor = Color.White;
                mostrarEtiquetasToolStripMenuItem.BackColor = Color.FromArgb(255, 31, 31, 31);
                mostrarEtiquetasToolStripMenuItem.ForeColor = Color.White;
                ocultarEtiquetasToolStripMenuItem.BackColor = Color.FromArgb(255, 31, 31, 31);
                ocultarEtiquetasToolStripMenuItem.ForeColor = Color.White;
                BtnPrincipal.ForeColor = Color.White;
                BtnAcercaDe.ForeColor = Color.White;
                BtnOpciones.ForeColor = Color.White;
                BtnSalir.ForeColor = Color.White;
                principalToolStripMenuItem.ForeColor = Color.White;
                principalToolStripMenuItem.BackColor = Color.FromArgb(255, 31, 31, 31);
                utilidadesToolStripMenuItem.ForeColor = Color.White;
                utilidadesToolStripMenuItem.BackColor = Color.FromArgb(255, 31, 31, 31);
                salirToolStripMenuItem.ForeColor = Color.White;
                salirToolStripMenuItem.BackColor = Color.FromArgb(255, 31, 31, 31);
                //ahora configuro de la barra menu, los contenedores internos
            }
        }

        private void Carnicería_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CmsMenuContextual.Show(MousePosition);
            }
        }

        private void añadirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAñadirEditarClientes = new AñadirEditarClientesView();
            frmAñadirEditarClientes.ShowDialog();
        }

        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAñadirEditarClientes = new AñadirEditarClientesView();
            frmAñadirEditarClientes.ShowDialog();
        }

        private void añadirEditarCobradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAñadirEditarCobradores = new AñadirEditarCobradoresView();
            frmAñadirEditarCobradores.ShowDialog();
        }

        private void listadoCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAñadirEditarCobradores = new AñadirEditarCobradoresView();
            frmAñadirEditarCobradores.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var añadirEditarProductosView = new AñadirEditarProductosView();
            añadirEditarProductosView.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var añadirEditarProductosView = new AñadirEditarProductosView();
            añadirEditarProductosView.ShowDialog();
        }

        private void nuevosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var añadirEditarVentasView = new AñadirEditarVentasView();
            añadirEditarVentasView.ShowDialog();
        }

        private void HomeCarniceríaView_Activated(object sender, EventArgs e)
        {
            if (UsuarioLogueado == null)
            {
                var frmLogin = new LoginView();
                frmLogin.ShowDialog();
                if (UsuarioLogueado == null)
                    Application.Exit();
            }
        }

        private void impresiónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteClientesView = new ReporteClientesView();
            reporteClientesView.ShowDialog();
        }

        private void impresiónProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteProductosView = new ReporteProductosView();
            reporteProductosView.ShowDialog();
        }

        private void impresiónCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteCobradorView = new ReporteCobradoresView();
            reporteCobradorView.ShowDialog();
        }

        private void impresiónVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteVentasView = new ReporteVentasView();
            reporteVentasView.ShowDialog();
        }

        private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var añadirEditarVentasView = new AñadirEditarVentasView();
            añadirEditarVentasView.ShowDialog();
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            var loginView = new LoginView();
            loginView.ShowDialog();
        }

        private void btnCambiarUserNavMenu_Click(object sender, EventArgs e)
        {
            var loginView = new LoginView();
            loginView.ShowDialog();
        }
    }
}