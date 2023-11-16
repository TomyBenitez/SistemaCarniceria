using FrmCosmopolita.Utils;
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
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carnicería.Presentation
{
    public partial class AñadirEditarCobradoresView : Form
    {
        CarniceríaContext db = new CarniceríaContext();
        Cobrador cobrador;
        public int idCobradorSeleccionado = 0;
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
            grdCobradores.DataSource = await db.Cobradores.ToListAsync();
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
            grdCobradores.DataSource = await db.Cobradores.Where(c => c.Apellido_Nombre.Contains(cadenaDeBusqueda)).ToListAsync();
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
            txtApellido_Nombre.Text = cobrador.Apellido_Nombre;
            txtDireccion.Text = cobrador.Dirección;
            txtTelefono.Text = cobrador.Teléfono;
            txtPassword.Text = cobrador.Password;
            txtUser.Text = cobrador.Username;
            cboPermisos.SelectedIndex = (int)cobrador.Tipocobrador;
            txtCodigo.Text = cobrador.Id.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            cobrador = new Cobrador();
            CargarDatosActividad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 1;
            HabilitarBotones(true);
            if (idCobradorSeleccionado != 0)
            {
                cobrador = db.Cobradores.Find(idCobradorSeleccionado);
                CargarDatosActividad();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPestañaGeneral.SelectedIndex = 0;
            HabilitarBotones(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cobrador.Apellido_Nombre = txtApellido_Nombre.Text;
            cobrador.Dirección = txtDireccion.Text;
            cobrador.Teléfono = txtTelefono.Text;
            cobrador.Username = txtUser.Text;
            cobrador.Password = Helper.ObtenerHashSha256(txtPassword.Text);
            cobrador.Tipocobrador = (TipoCobradorEnum)cboPermisos.SelectedValue;
            if (cobrador.Id == 0)
            {
                db.Cobradores.Add(cobrador);
            }
            else
            {
                db.Entry(cobrador).State = EntityState.Modified;
            }
            db.SaveChanges();
            tabPestañaGeneral.SelectedIndex = 0;
            ActualizarGrilla();
            HabilitarBotones(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idCobrador = (int)grdCobradores.CurrentRow.Cells[0].Value;
            var nombreCobrador = (string)grdCobradores.CurrentRow.Cells[1].Value;
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar a {nombreCobrador}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                var CobradorBorrar = db.Cobradores.Find(idCobrador);
                db.Cobradores.Remove(CobradorBorrar);
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
            idCobradorSeleccionado = (int)grdCobradores.CurrentRow.Cells[0].Value;
            cobrador = db.Cobradores.Find(idCobradorSeleccionado);
            CargarDatosActividad();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
            txtBusqueda.Clear();
        }
    }
}
