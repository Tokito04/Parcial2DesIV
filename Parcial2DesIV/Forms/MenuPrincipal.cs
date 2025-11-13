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
    public partial class MenuPrincipal : Form
    {
        public Modelos.Usuarios UsuarioActual;

        private List<Modelos.Cuentas> cuentasTransaccion;
        public MenuPrincipal(Modelos.Usuarios usuario)
        {
            InitializeComponent();
            this.UsuarioActual = usuario;

            this.Load += MenuPrincipal_Load;
            this.btnTransaccion.Click += btnTransaccion_Click;
            this.btnHistorial.Click += btnHistorial_Click;
            this.btnCerrarSesión.Click += btnCerrarSesión_Click;
        }

        

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // Mostrar mensaje de bienvenida
            
            lblNombreUsuario.Text = $"Bienvenido {this.UsuarioActual.nombre}";
            CargarCuentasUsuario(this.UsuarioActual.id);
            
        }

        private void CargarCuentasUsuario(int idUsuario)
        {
            try
            {
                Datos.Database db = new Datos.Database();

                try
                {

                    cuentasTransaccion = db.ObtenerCuentasUsuario(idUsuario);
                }
                catch
                {

                    cuentasTransaccion = null;
                }

                dgvCuentas.DataSource = cuentasTransaccion;
                dgvCuentas.Columns["id"].Visible = false;
                dgvCuentas.Columns["usuario_id"].Visible = false;
                dgvCuentas.Columns["num_cuenta"].HeaderText = "Número de Cuenta";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message);
            }
        }

        

        private void btnTransaccion_Click(object sender, EventArgs e)
        {

            Transacción trans = new Transacción(this.cuentasTransaccion);
            // Mostrar como formulario normal (no modal)
            trans.FormClosed += (s, args) =>
            {
                if (this.UsuarioActual != null)
                {
                    CargarCuentasUsuario(this.UsuarioActual.id);
                }
            };

            trans.Show();

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Abrir formulario de historial pasando el usuario actual si existe
            Historial h;
            h = new Historial(this.UsuarioActual);
            h.Show();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {

            try
            {
                using (Cierre cierre = new Cierre())
                {
                    var result = cierre.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        // Llevar al Login
                        var login = new Login();
                        login.Show();
                        this.Close();
                        return;
                    }
                    else if (result == DialogResult.No)
                    {

                        return;
                    }
                    else
                    {

                        return;
                    }
                }
            }
            catch
            {
                // Si ocurre un error al mostrar el formulario de cierre, por seguridad volver al Login
                var login = new Login();
                login.Show();
                this.Close();
            }
        }
    }
}
