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
    public partial class AñadirEditarClientesView : Form
    {
        CarniceríaContext db = new CarniceríaContext();
        Cliente clientes;
        public int idClienteSeleccionado = 0;
        public AñadirEditarClientesView()
        {
            InitializeComponent();
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void ActualizarGrilla()
        {
            grdClientes.DataSource = await db.Clientes.ToListAsync();
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(txtBusqueda.Text);
        }

        private async void ActualizarGrilla(string cadenaDeBusqueda)
        {
            grdClientes.DataSource = await db.Clientes.Where(c => c.Apellido_Nombre.Contains(cadenaDeBusqueda)).ToListAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HabilitarBotones(bool valor)
        {
            if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Encargado)
            {
                txtApellido_Nombre.Enabled = valor;
                txtDireccion.Enabled = valor;
                txtTelefono.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            else if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Empleado)
            {
                txtApellido_Nombre.Enabled = valor;
                txtDireccion.Enabled = valor;
                txtTelefono.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                txtApellido_Nombre.Enabled = valor;
                txtDireccion.Enabled = valor;
                txtTelefono.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            clientes = new Cliente();
            CargarDatosActividad();
        }

        private void CargarDatosActividad()
        {
            txtApellido_Nombre.Text = clientes.Apellido_Nombre;
            txtDireccion.Text = clientes.Dirección;
            txtTelefono.Text = clientes.Teléfono;
            txtCodigo.Text = clientes.Id.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            if (idClienteSeleccionado != 0)
            {
                clientes = db.Clientes.Find(idClienteSeleccionado);
                CargarDatosActividad();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            clientes.Apellido_Nombre = txtApellido_Nombre.Text;
            clientes.Dirección = txtDireccion.Text;
            clientes.Teléfono = txtTelefono.Text;
            if (clientes.Id == 0)
            {
                db.Clientes.Add(clientes);
            }
            else
            {
                db.Entry(clientes).State = EntityState.Modified;
            }
            db.SaveChanges();
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idCliente = (int)grdClientes.CurrentRow.Cells[0].Value;
            var nombreCliente = (string)grdClientes.CurrentRow.Cells[1].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar a {nombreCliente}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var ClienteBorrar = db.Clientes.Find(idCliente);
                db.Clientes.Remove(ClienteBorrar);
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
            idClienteSeleccionado = (int)grdClientes.CurrentRow.Cells[0].Value;
            clientes = db.Clientes.Find(idClienteSeleccionado);
            CargarDatosActividad();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
            txtBusqueda.Clear();
        }
    }
}
