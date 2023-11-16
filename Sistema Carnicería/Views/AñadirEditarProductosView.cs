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
using System.Windows.Forms;

namespace Sistema_Carnicería.Presentation
{
    public partial class AñadirEditarProductosView : Form
    {
        CarniceríaContext db = new CarniceríaContext();
        Producto producto;
        public int idProductoSeleccionado = 0;
        public AñadirEditarProductosView()
        {
            InitializeComponent();
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void ActualizarGrilla()
        {
            grdProductos.DataSource = await db.Productos.ToListAsync();
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
            grdProductos.DataSource = await db.Productos.Where(p => p.Nombre.Contains(cadenaDeBusqueda)).ToListAsync();
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
            producto = new Producto();
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            txtNombreProducto.Text = producto.Nombre;
            NUDMonto.Value = producto.Monto;
            txtCodigo.Text = producto.Id.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            if (idProductoSeleccionado != 0)
            {
                producto = db.Productos.Find(idProductoSeleccionado);
                CargarDatosProducto();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto.Nombre = txtNombreProducto.Text;
            producto.Monto = NUDMonto.Value;
            if (producto.Id == 0)
            {
                db.Productos.Add(producto);
            }
            else
            {
                db.Entry(producto).State = EntityState.Modified;
            }
            db.SaveChanges();
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idProducto = (int)grdProductos.CurrentRow.Cells[0].Value;
            var nombreProducto = (string)grdProductos.CurrentRow.Cells[1].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar el prodcuto {nombreProducto}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var ProductoBorrar = db.Productos.Find(idProducto);
                db.Productos.Remove(ProductoBorrar);
                db.SaveChanges();
                ActualizarGrilla();
            }
        }

        private void tabPestañaGeneral_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void grdClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idProductoSeleccionado = (int)grdProductos.CurrentRow.Cells[0].Value;
            producto = db.Productos.Find(idProductoSeleccionado);
            CargarDatosProducto();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
            txtBusqueda.Clear();
        }
    }
}
