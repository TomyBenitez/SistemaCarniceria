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
using System.Windows.Forms;

namespace Sistema_Carnicería.Presentation
{
    public partial class AñadirEditarProductosView : Form
    {
        private ProductosRepository productosRepository = new ProductosRepository();
        Producto ProductoEditado { get; set; }
        public AñadirEditarProductosView()
        {
            InitializeComponent();
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void ActualizarGrilla()
        {
            grdProductos.DataSource = null;
            var todosLosProductos = await productosRepository.GetAllAsync();
            grdProductos.DataSource = todosLosProductos.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(txtBusqueda.Text);
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private async void ActualizarGrilla(string cadenaDeBusqueda)
        {
            var todosLosProductos = await productosRepository.GetAllAsync();
            var productosFiltrados = todosLosProductos
                .Where(c => c.Nombre.Contains(cadenaDeBusqueda))
                .ToList();
            grdProductos.DataSource = productosFiltrados;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HabilitarBotones(bool valor)
        {
            if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Encargado)
            {
                txtNombreProducto.Enabled = valor;
                NUDMonto.Enabled = valor;
                txtNombreProducto.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = true;
            }
            else if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Empleado)
            {
                txtNombreProducto.Enabled = valor;
                NUDMonto.Enabled = valor;
                txtNombreProducto.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                txtNombreProducto.Enabled = valor;
                NUDMonto.Enabled = valor;
                txtNombreProducto.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            ProductoEditado = new Producto();
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            txtNombreProducto.Text = ProductoEditado.Nombre;
            NUDMonto.Value = ProductoEditado.Monto;
            txtCodigo.Text = ProductoEditado.Id.ToString();
        }

        private async Task RecuperarDatosProductoSeleccionado()
        {
            int idNotaSeleccionada = (int)grdProductos.CurrentRow.Cells[0].Value;
            ProductoEditado = await productosRepository.GetById(idNotaSeleccionada);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            await RecuperarDatosProductoSeleccionado();
            CargarDatosProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoEditado.Nombre = txtNombreProducto.Text;
            ProductoEditado.Monto = NUDMonto.Value;
            if (ProductoEditado.Id == 0)
            {
                await productosRepository.AddAsync(ProductoEditado);
            }
            else
            {
                await productosRepository.UpdateAsync(ProductoEditado);
            }
            ProductoEditado = null;
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idProducto = (int)grdProductos.CurrentRow.Cells[0].Value;
            var nombreProducto = (string)grdProductos.CurrentRow.Cells[1].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar el prodcuto {nombreProducto}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await productosRepository.RemoveAsync(idProducto);
                ActualizarGrilla();
            }
        }

        private void tabPestañaGeneral_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void grdClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProductos.CurrentRow != null)
            {
                var productoSeleccionado = grdProductos.CurrentRow.DataBoundItem as Producto;
                if (productoSeleccionado != null)
                {
                    ProductoEditado = productoSeleccionado;
                }
            }
            CargarDatosProducto();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
            txtBusqueda.Clear();
        }
    }
}
