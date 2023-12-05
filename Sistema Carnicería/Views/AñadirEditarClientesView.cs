using FrmCosmopolita.Utils;
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
    public partial class AñadirEditarClientesView : Form
    {
        private ClientesRepository clientesRepository = new ClientesRepository();
        Cliente ClienteEditado { get; set; }
        public AñadirEditarClientesView()
        {
            InitializeComponent();
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void ActualizarGrilla()
        {
            grdClientes.DataSource = null;
            var todosLosClientes = await clientesRepository.GetAllAsync();
            grdClientes.DataSource = todosLosClientes.ToList();
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
            var todosLosClientes = await clientesRepository.GetAllAsync();
            var clientesFiltrados = todosLosClientes
                .Where(c => c.Apellido_Nombre.Contains(cadenaDeBusqueda))
                .ToList();
            grdClientes.DataSource = clientesFiltrados;

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
            ClienteEditado = new Cliente();
            CargarDatosActividad();
        }

        private void CargarDatosActividad()
        {
            txtApellido_Nombre.Text = ClienteEditado.Apellido_Nombre;
            txtDireccion.Text = ClienteEditado.Dirección;
            txtTelefono.Text = ClienteEditado.Teléfono;
            txtCodigo.Text = ClienteEditado.Id.ToString();
        }

        private async Task RecuperarDatosClienteSeleccionado()
        {
            int idNotaSeleccionada = (int)grdClientes.CurrentRow.Cells[0].Value;
            ClienteEditado = await clientesRepository.GetById(idNotaSeleccionada);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            await RecuperarDatosClienteSeleccionado();
            CargarDatosActividad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteEditado.Apellido_Nombre = txtApellido_Nombre.Text;
            ClienteEditado.Dirección = txtDireccion.Text;
            ClienteEditado.Teléfono = txtTelefono.Text;
            if (ClienteEditado.Id == 0)
            {
                await clientesRepository.AddAsync(ClienteEditado);
            }
            else
            {
                await clientesRepository.UpdateAsync(ClienteEditado);
            }
            ClienteEditado = null;
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idCliente = (int)grdClientes.CurrentRow.Cells[0].Value;
            var nombreCliente = (string)grdClientes.CurrentRow.Cells[1].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar a {nombreCliente}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await clientesRepository.RemoveAsync(idCliente);
                ActualizarGrilla();
            }
        }

        private void tabPestañaGeneral_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void grdClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClientes.CurrentRow != null)
            {
                var clienteSeleccionado = grdClientes.CurrentRow.DataBoundItem as Cliente;
                if (clienteSeleccionado != null)
                {
                    ClienteEditado = clienteSeleccionado;
                }
            }
            CargarDatosActividad();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
            txtBusqueda.Clear();
        }
    }
}
