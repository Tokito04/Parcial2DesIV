using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2DesIV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }
            Datos.Database db = new Datos.Database();
            var usuario = db.ValidarLogin(txtUsuario.Text, txtContrasena.Text);
            if (usuario != null)
            {
                MessageBox.Show("Login exitoso. Bienvenido " + usuario.nombre);
                MenuPrincipal menu = new MenuPrincipal(usuario);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                MenuPrincipal menu = new MenuPrincipal(usuario);
                menu.Show();
                this.Hide();

            }
        }
    }
}
