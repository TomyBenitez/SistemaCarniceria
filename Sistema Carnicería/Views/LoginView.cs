using FrmCosmopolita.Utils;
using Sistema_Carnicería.Data;
using Sistema_Carnicería.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carnicería.Views
{
    public partial class LoginView : Form
    {
        CarniceríaContext db = new CarniceríaContext();
        int intentosfallidos = 0;
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var pass = Helper.ObtenerHashSha256(txtPassword.Text);
            var usuarioLogueado = db.Cobradores.Where(u => u.Username == user &&
                                                    u.Password == pass)
                                                    .FirstOrDefault();
            if (usuarioLogueado == null)
            {
                intentosfallidos++;
                if (intentosfallidos == 3)
                {
                    Application.Exit();
                }
                MessageBox.Show("Error, usuario o contraseña inválida");
                txtUser.Text = "";
                txtPassword.Text = "";
                HomeCarniceríaView.UsuarioLogueado = null;
            }
            else
            {
                HomeCarniceríaView.UsuarioLogueado = usuarioLogueado;
                MessageBox.Show("Usuario logueado con éxito");
                this.Close();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
