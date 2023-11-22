using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sistema_Carnicería.Data;
using Sistema_Carnicería.Enums;
using Sistema_Carnicería.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Sistema_Carnicería.Presentation
{
    public partial class AñadirEditarVentasView : Form
    {
        CarniceríaContext db = new CarniceríaContext();
        Venta venta;
        public int idVentaSeleccionada = 0;
        public List<Producto> productosArray = new List<Producto>();
        public AñadirEditarVentasView()
        {
            InitializeComponent();
            CargarDatosPantalla();
            ActualizarGrilla();
            HabilitarBotones(false);
        }
        private void CargarDatosPantalla()
        {
            CargarCboClientes();
            CargarCboProductos();
        }
        private void CargarCboClientes()
        {
            cboCliente.DataSource = db.Clientes.ToList();
            cboCliente.DisplayMember = "Apellido_Nombre";
            cboCliente.ValueMember = "Id";
        }
        private void CargarCboProductos()
        {
            productosArray = db.Productos.ToList();
            cboProductos.DataSource = productosArray;
            cboProductos.DisplayMember = "Nombre";
            cboProductos.ValueMember = "Id";
        }

        private async void ActualizarGrilla()
        {
            grdVentas.DataSource = await db.Ventas.Include(v => v.Cobrador).DefaultIfEmpty().Include(v => v.Cliente).DefaultIfEmpty().Include(v => v.Producto).DefaultIfEmpty().ToListAsync();
            grdVentas.Columns.RemoveAt(1);
            grdVentas.Columns.RemoveAt(2);
            grdVentas.Columns.RemoveAt(3);
            grdVentas.Columns.RemoveAt(3);
            grdVentas.Columns.RemoveAt(4);
        }

        private async void ActualizarGrilla(string cadenaDeBusqueda)
        {
            grdVentas.DataSource = await db.Ventas.Where(v => v.Fecha.ToString().Contains(cadenaDeBusqueda)).Include(v => v.Cobrador).DefaultIfEmpty().Include(v => v.Cliente).DefaultIfEmpty().Include(v => v.Producto).DefaultIfEmpty().ToListAsync();
            grdVentas.Columns.RemoveAt(1);
            grdVentas.Columns.RemoveAt(2);
            grdVentas.Columns.RemoveAt(3);
            grdVentas.Columns.RemoveAt(3);
            grdVentas.Columns.RemoveAt(4);
        }
        private void HabilitarBotones(bool valor)
        {
            if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Encargado)
            {
                cboCliente.Enabled = valor;
                cboProductos.Enabled = valor;
                NUDcantidad.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = true;
            }
            else if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Empleado)
            {
                cboCliente.Enabled = valor;
                cboProductos.Enabled = valor;
                NUDcantidad.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                cboCliente.Enabled = valor;
                cboProductos.Enabled = valor;
                NUDcantidad.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
        private void CargarDatosVentas()
        {
            cboCliente.SelectedValue = venta.ClienteId;
            cboProductos.SelectedValue = venta.ProductoId;
            NUDcantidad.Value = venta.Cantidad;
            txtCodigo.Text = venta.Id.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            venta = new Venta();
            CargarDatosVentas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            if (idVentaSeleccionada != 0)
            {
                venta = db.Ventas.Find(idVentaSeleccionada);
                CargarDatosVentas();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            venta.ClienteId = Convert.ToInt32(cboCliente.SelectedValue);
            venta.CobradorId = HomeCarniceríaView.UsuarioLogueado.Id;
            venta.ProductoId = Convert.ToInt32(cboProductos.SelectedValue);
            venta.Cantidad = (int)NUDcantidad.Value;
            venta.Fecha = DateTime.Now;
            venta.MontoTotal = productosArray.FirstOrDefault(p => p.Id == venta.ProductoId).Monto;
            if (venta.Id == 0)
            {
                db.Ventas.Add(venta);
            }
            else
            {
                db.Entry(venta).State = EntityState.Modified;
            }
            db.SaveChanges();
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idVenta = (int)grdVentas.CurrentRow.Cells[0].Value;
            var nombreVenta = grdVentas.CurrentRow.Cells[3].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar la venta= {nombreVenta}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var borrarVenta = db.Ventas.Find(idVenta);
                db.Ventas.Remove(borrarVenta);
                db.SaveChanges();
                ActualizarGrilla();
            }
        }

        private void tabPestañaGeneral_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void grdCobradores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grilla = grdVentas.CurrentRow.Cells[0].Value;
            if (grilla!=null)
            {
                idVentaSeleccionada = (int)grdVentas.CurrentRow.Cells[0].Value;
                venta = db.Ventas.Find(idVentaSeleccionada);
                CargarDatosVentas();
            }
        }

        private void DTPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(DTPicker.Value.ToString("yyyy-MM-dd"));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
