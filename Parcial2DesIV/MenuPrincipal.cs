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
        public MenuPrincipal()
        {
            InitializeComponent();
            // Enlazar eventos para el caso de creación sin usuario
            this.Load += MenuPrincipal_Load;
            this.btnTransaccion.Click += btnTransaccion_Click;
            this.btnHistorial.Click += btnHistorial_Click;
            this.btnCerrarSesión.Click += btnCerrarSesión_Click;
        }

        public MenuPrincipal(Modelos.Usuarios usuario)
        {
            InitializeComponent();
            this.UsuarioActual = usuario;

            this.Load += MenuPrincipal_Load;
            this.btnTransaccion.Click += btnTransaccion_Click;
            this.btnHistorial.Click += btnHistorial_Click;
            this.btnCerrarSesión.Click += btnCerrarSesión_Click;
        }

        public Modelos.Usuarios UsuarioActual { get; set; }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // Mostrar mensaje de bienvenida
            if (this.UsuarioActual != null)
            {
                lblNombreUsuario.Text = $"Bienvenido {this.UsuarioActual.nombre}";
                CargarCuentasUsuario(this.UsuarioActual.id);
            }
            else
            {
                lblNombreUsuario.Text = "Bienvenido";
                CargarCuentasUsuario(-1);
            }
        }

        private void CargarCuentasUsuario(int idUsuario)
        {
            try
            {
                var db = new Datos.Database();
                List<Modelos.Cuentas> cuentas = null;

                try
                {
                    if (idUsuario > 0)
                    {
                        cuentas = db.ObtenerCuentasUsuario(idUsuario);
                    }
                }
                catch
                {
                
                    cuentas = null;
                }


                if (cuentas == null || cuentas.Count == 0)
                {
                    cuentas = new List<Modelos.Cuentas>
                    {
                        new Modelos.Cuentas { id = 1, num_cuenta = "000111222333", nombre = "Cuenta Prueba A", saldo = 5000m, usuario_id = idUsuario > 0 ? idUsuario : 1 },
                        new Modelos.Cuentas { id = 2, num_cuenta = "000444555666", nombre = "Cuenta Prueba B", saldo = 1200.50m, usuario_id = idUsuario > 0 ? idUsuario : 1 }
                    };
                }


                cboCuentas.FormattingEnabled = true;
                cboCuentas.DataSource = null;
                cboCuentas.ValueMember = "id";
                cboCuentas.DataSource = cuentas;

                cboCuentas.Format -= CboCuentas_Format;
                cboCuentas.Format += CboCuentas_Format;

                if (cuentas != null && cuentas.Count > 0)
                {
                    cboCuentas.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message);
            }
        }

        private void CboCuentas_Format(object sender, ListControlConvertEventArgs e)
        {
            var cuenta = e.ListItem as Modelos.Cuentas;
            if (cuenta != null)
            {
                e.Value = string.Format("{0} - {1} (Saldo: {2:C2})", cuenta.num_cuenta, cuenta.nombre, cuenta.saldo);
            }
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            // Verificar que haya una cuenta seleccionada en el ComboBox
            if (cboCuentas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una cuenta origen en la lista.");
                return;
            }

            var cuenta = cboCuentas.SelectedItem as Modelos.Cuentas;

            if (cuenta == null)
            {
                // Crear cuenta temporal de prueba
                cuenta = new Modelos.Cuentas
                {
                    id = 0,
                    num_cuenta = "000123456789",
                    nombre = "Cuenta de Prueba",
                    saldo = 1000m,
                    usuario_id = 0
                };
            }

 
            Transacción trans = new Transacción(cuenta, this.UsuarioActual);
            var result = trans.ShowDialog();

            if (result == DialogResult.OK && this.UsuarioActual != null)
            {
                CargarCuentasUsuario(this.UsuarioActual.id);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Abrir formulario de historial pasando el usuario actual si existe
            Historial h;
            if (this.UsuarioActual != null)
            {
                h = new Historial(this.UsuarioActual);
            }
            else
            {
                // Para pruebas locales, pasar el id de la primera cuenta si existe
                var primera = cboCuentas.SelectedItem as Modelos.Cuentas;
                if (primera != null)
                {
                    h = new Historial(primera.usuario_id);
                }
                else
                {
                    h = new Historial();
                }
            }
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
