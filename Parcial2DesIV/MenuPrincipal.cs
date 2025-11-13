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
            // Puedes guardar el usuario para mostrar información personalizada
            this.UsuarioActual = usuario;

            // Enlazar eventos
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
            }
        }

        private void CargarCuentasUsuario(int idUsuario)
        {
            try
            {
                var db = new Datos.Database();
                List<Modelos.Cuentas> cuentas = db.ObtenerCuentasUsuario(idUsuario);
                // Enlazar lista al ComboBox mostrando número, nombre y saldo
                cboCuentas.FormattingEnabled = true;
                cboCuentas.DataSource = null;
                cboCuentas.ValueMember = "id";
                cboCuentas.DataSource = cuentas;

                // Attach format handler to display combined text
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
            // Si el DataSource no es de tipo Cuentas (ej. valor de prueba), crear un objeto temporal
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

            // Abrir formulario de transacciones pasando la cuenta origen como modal
            Transacción trans = new Transacción(cuenta);
            var result = trans.ShowDialog();
            // Si la transacción fue confirmada correctamente, refrescar las cuentas
            if (result == DialogResult.OK && this.UsuarioActual != null)
            {
                CargarCuentasUsuario(this.UsuarioActual.id);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Abrir formulario de historial (si deseas pasar el usuario o id, agrega constructor)
            Historial h = new Historial();
            // Si el formulario Historial tiene lógica para cargar datos, podrías pasar el id
            h.Show();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            // Abrir formulario de cierre (opcional) y volver al Login
            try
            {
                Cierre cierre = new Cierre();
                cierre.ShowDialog();
            }
            catch
            {
                // Ignorar si no se desea mostrar el formulario de cierre
            }

            // Volver al Login
            var login = new Login();
            login.Show();
            this.Close();
        }
    }
}
