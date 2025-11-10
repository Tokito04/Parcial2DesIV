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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                List<Modelos.HistorialTransaccion> cuentas = db.ObtenerTransaccionesUsuario(usuario.id);
                dgtPrueba.DataSource = cuentas;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
