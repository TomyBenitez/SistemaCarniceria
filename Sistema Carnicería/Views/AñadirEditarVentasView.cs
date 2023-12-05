using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sistema_Carnicería.Data;
using Sistema_Carnicería.Enums;
using Sistema_Carnicería.Models;
using Sistema_Carnicería.Repositories;
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
        private VentasRepository ventasRepository = new VentasRepository();
        private ClientesRepository clientesRepository = new ClientesRepository();
        private ProductosRepository productosRepository = new ProductosRepository();
        Venta VentaEditada { get; set; }
        public List<Producto> productosArray = new List<Producto>();
        public List<Venta> ventasArray = new List<Venta>();
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
        private async Task CargarCboClientes()
        {
            var data = await clientesRepository.GetAllAsync();
            cboCliente.DataSource = data;
            cboCliente.DisplayMember = "Apellido_Nombre";
            cboCliente.ValueMember = "Id";
        }
        private async Task CargarCboProductos()
        {
            var data = await productosRepository.GetAllAsync();
            productosArray.Clear();
            productosArray = data.ToList();
            cboProductos.DataSource = data;
            cboProductos.DisplayMember = "Nombre";
            cboProductos.ValueMember = "Id";
        }

        private async void ActualizarGrilla()
        {
            grdVentas.DataSource = null;
            ventasArray.Clear();
            var ventas = await ventasRepository.GetAllAsync();
            var productos = await productosRepository.GetAllAsync();
            var clientes = await clientesRepository.GetAllAsync();
            foreach (var venta in ventas)
            {
                var producto = productos.FirstOrDefault(p => p.Id == venta.ProductoId);
                if (producto != null)
                {
                    var nombreProducto = producto.Nombre;
                    venta.NombreProducto = nombreProducto;
                }
                var cliente = clientes.FirstOrDefault(c => c.Id == venta.ClienteId);
                if (cliente != null)
                {
                    var nombreCliente = cliente.Apellido_Nombre;
                    venta.NombreCliente = nombreCliente;
                }
                ventasArray.Add(venta);
            }
            grdVentas.DataSource = ventasArray;
            grdVentas.Columns[1].Visible = false;
            grdVentas.Columns[2].Visible = false;
            grdVentas.Columns[3].Visible = false;
            grdVentas.Columns[4].Visible = false;
            grdVentas.Columns[6].Visible = false;
            grdVentas.Columns[7].Visible = false;
        }

        private async void ActualizarGrilla(string cadenaDeBusqueda)
        {
            grdVentas.DataSource = null;
            ventasArray.Clear();
            var todasLasVentas = await ventasRepository.GetAllAsync();
            var productos = await productosRepository.GetAllAsync();
            var clientes = await clientesRepository.GetAllAsync();
            var ventasFiltradas = todasLasVentas.Where(v => v.Fecha.Date == DateTime.Parse(cadenaDeBusqueda)).ToList();
            foreach (var venta in ventasFiltradas)
            {
                var producto = productos.FirstOrDefault(p => p.Id == venta.ProductoId);
                if (producto != null)
                {
                    var nombreProducto = producto.Nombre;
                    venta.NombreProducto = nombreProducto;
                }
                var cliente = clientes.FirstOrDefault(c => c.Id == venta.ClienteId);
                if (cliente != null)
                {
                    var nombreCliente = cliente.Apellido_Nombre;
                    venta.NombreCliente = nombreCliente;
                }
                ventasArray.Add(venta);
            }
            grdVentas.DataSource = ventasArray;
            grdVentas.Columns[1].Visible = false;
            grdVentas.Columns[2].Visible = false;
            grdVentas.Columns[3].Visible = false;
            grdVentas.Columns[4].Visible = false;
            grdVentas.Columns[6].Visible = false;
            grdVentas.Columns[7].Visible = false;
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
            cboCliente.SelectedValue = VentaEditada.ClienteId;
            cboProductos.SelectedValue = VentaEditada.ProductoId;
            NUDcantidad.Value = VentaEditada.Cantidad;
            txtCodigo.Text = VentaEditada.Id.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            VentaEditada = new Venta();
            CargarDatosVentas();
        }
        private async Task RecuperarDatosVentaSeleccionada()
        {
            int idVentaSeleccionada = (int)grdVentas.CurrentRow.Cells[0].Value;
            VentaEditada = await ventasRepository.GetById(idVentaSeleccionada);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            await RecuperarDatosVentaSeleccionada();
            CargarDatosVentas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            VentaEditada.ClienteId = Convert.ToInt32(cboCliente.SelectedValue);
            VentaEditada.CobradorId = HomeCarniceríaView.UsuarioLogueado.Id;
            VentaEditada.ProductoId = Convert.ToInt32(cboProductos.SelectedValue);
            VentaEditada.Cantidad = (int)NUDcantidad.Value;
            VentaEditada.Fecha = DateTime.Now;
            VentaEditada.MontoTotal = productosArray.FirstOrDefault(p => p.Id == VentaEditada.ProductoId).Monto;
            if (VentaEditada.Id == 0)
            {
                await ventasRepository.AddAsync(VentaEditada);
            }
            else
            {
                await ventasRepository.UpdateAsync(VentaEditada);
            }
            VentaEditada = null;
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idVenta = (int)grdVentas.CurrentRow.Cells[0].Value;
            var nombreVenta = grdVentas.CurrentRow.Cells[3].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar la venta= {nombreVenta}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await ventasRepository.RemoveAsync(idVenta);
                ActualizarGrilla();
            }
        }

        private void tabPestañaGeneral_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void grdCobradores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdVentas.CurrentRow != null)
            {
                var ventaSeleccionada = grdVentas.CurrentRow.DataBoundItem as Venta;
                if (ventaSeleccionada != null)
                {
                    VentaEditada = ventaSeleccionada;
                    CargarDatosVentas();
                }
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
