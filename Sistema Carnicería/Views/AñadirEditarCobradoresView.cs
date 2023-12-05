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
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carnicería.Presentation
{
    public partial class AñadirEditarCobradoresView : Form
    {
        private CobradoresRepository cobradoresRepository = new CobradoresRepository();
        Cobrador CobradorEditado { get; set; }
        public AñadirEditarCobradoresView()
        {
            InitializeComponent();
            CargarCboPermisos();
            ActualizarGrilla();
        }

        private void CargarCboPermisos()
        {
            cboPermisos.DataSource = Enum.GetValues(typeof(TipoCobradorEnum));
        }

        private async void ActualizarGrilla()
        {
            grdCobradores.DataSource = null;
            var todosLosCobradores = await cobradoresRepository.GetAllAsync();
            grdCobradores.DataSource = todosLosCobradores.ToList();
            if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Encargado)
            {
                PermisosUsuarioEncargado(true);
            }
            else if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Empleado)
            {
                PermisosUsuarioEmpleado(true);
            }
        }

        private void PermisosUsuarioEmpleado(bool valor)
        {
            grdCobradores.Columns[5].Visible = false;
            txtPassword.UseSystemPasswordChar = valor;
            btnEliminar.Enabled = !valor;
            btnModificar.Enabled = !valor;
        }

        private void PermisosUsuarioEncargado(bool valor)
        {
            grdCobradores.Columns[5].Visible = false;
            txtPassword.UseSystemPasswordChar = valor;
            btnEliminar.Enabled = !valor;
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
            var todosLosCobradores = await cobradoresRepository.GetAllAsync();
            var cobradoresFiltrados = todosLosCobradores
                .Where(c => c.Apellido_Nombre.Contains(cadenaDeBusqueda))
                .ToList();
            grdCobradores.DataSource = cobradoresFiltrados;
            if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Encargado)
            {
                PermisosUsuarioEncargado(true);
            }
            else if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Empleado)
            {
                PermisosUsuarioEmpleado(true);
            }
        }
        private void HabilitarBotones(bool valor)
        {
            if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Encargado)
            {
                txtApellido_Nombre.Enabled = valor;
                txtDireccion.Enabled = valor;
                txtTelefono.Enabled = valor;
                txtPassword.Enabled = valor;
                txtUser.Enabled = valor;
                txtPassword.UseSystemPasswordChar = !valor;
                cboPermisos.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
            }
            else if (HomeCarniceríaView.UsuarioLogueado.Tipocobrador == TipoCobradorEnum.Empleado)
            {
                txtApellido_Nombre.Enabled = valor;
                txtDireccion.Enabled = valor;
                txtTelefono.Enabled = valor;
                txtPassword.Enabled = valor;
                txtUser.Enabled = valor;
                txtPassword.UseSystemPasswordChar = !valor;
                cboPermisos.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
            }
            else
            {
                txtApellido_Nombre.Enabled = valor;
                txtDireccion.Enabled = valor;
                txtTelefono.Enabled = valor;
                txtPassword.Enabled = valor;
                txtUser.Enabled = valor;
                txtPassword.UseSystemPasswordChar = false;
                cboPermisos.Enabled = valor;
                btnGuardar.Enabled = valor;
                btnCancelar.Enabled = valor;
            }
        }
        private void CargarDatosActividad()
        {
            txtApellido_Nombre.Text = CobradorEditado.Apellido_Nombre;
            txtDireccion.Text = CobradorEditado.Dirección;
            txtTelefono.Text = CobradorEditado.Teléfono;
            txtPassword.Text = CobradorEditado.Password;
            txtUser.Text = CobradorEditado.Username;
            cboPermisos.SelectedIndex = (int)CobradorEditado.Tipocobrador;
            txtCodigo.Text = CobradorEditado.Id.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            CobradorEditado = new Cobrador();
            CargarDatosActividad();
        }

        private async Task RecuperarDatosCobradoresSeleccionado()
        {
            int idNotaSeleccionada = (int)grdCobradores.CurrentRow.Cells[0].Value;
            CobradorEditado = await cobradoresRepository.GetById(idNotaSeleccionada);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            await RecuperarDatosCobradoresSeleccionado();
            CargarDatosActividad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            CobradorEditado.Apellido_Nombre = txtApellido_Nombre.Text;
            CobradorEditado.Dirección = txtDireccion.Text;
            CobradorEditado.Teléfono = txtTelefono.Text;
            CobradorEditado.Username = txtUser.Text;
            CobradorEditado.Password = Helper.ObtenerHashSha256(txtPassword.Text);
            CobradorEditado.Tipocobrador = (TipoCobradorEnum)cboPermisos.SelectedValue;
            if (CobradorEditado.Id == 0)
            {
                await cobradoresRepository.AddAsync(CobradorEditado);
            }
            else
            {
                await cobradoresRepository.UpdateAsync(CobradorEditado);
            }
            CobradorEditado = null;
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idCobrador = (int)grdCobradores.CurrentRow.Cells[0].Value;
            var nombreCobrador = (string)grdCobradores.CurrentRow.Cells[1].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar a {nombreCobrador}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await cobradoresRepository.RemoveAsync(idCobrador);
                ActualizarGrilla();
            }
        }

        private void tabPestañaGeneral_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void grdCobradores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCobradores.CurrentRow != null)
            {
                var clienteSeleccionado = grdCobradores.CurrentRow.DataBoundItem as Cobrador;
                if (clienteSeleccionado != null)
                {
                    CobradorEditado = clienteSeleccionado;
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
