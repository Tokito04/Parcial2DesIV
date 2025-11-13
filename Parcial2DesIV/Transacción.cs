using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Parcial2DesIV
{
    public partial class Transacción : Form
    {
        private Modelos.Cuentas CuentaOrigen;
        private Modelos.Usuarios UsuarioActual;

        public Transacción()
        {
            InitializeComponent();
            this.btnSiguienteConfirmacion.Click += BtnSiguienteConfirmacion_Click;
            this.Load += Transacción_Load;

            // validar entrada del monto: permitir solo números, punto o coma y control
            this.txtMonto.KeyPress -= TxtMonto_KeyPress;
            this.txtMonto.KeyPress += TxtMonto_KeyPress;
        }

        public Transacción(Modelos.Cuentas cuentaOrigen) : this()
        {
            this.CuentaOrigen = cuentaOrigen;
            // Si se recibe cuenta origen, mostrarla en la etiqueta
            if (cuentaOrigen != null)
            {
                lblCuentaOrigen.Text = $"Cuenta origen: {cuentaOrigen.num_cuenta} - {cuentaOrigen.nombre} (Saldo: {cuentaOrigen.saldo:C2})";
            }
        }

        // Nueva sobrecarga que recibe cuenta origen y usuario
        public Transacción(Modelos.Cuentas cuentaOrigen, Modelos.Usuarios usuario) : this(cuentaOrigen)
        {
            this.UsuarioActual = usuario;
        }

        public Transacción(Modelos.Usuarios usuario) : this()
        {
            this.UsuarioActual = usuario;
        }

        private void Transacción_Load(object sender, EventArgs e)
        {
            if (this.CuentaOrigen == null)
            {
                lblCuentaOrigen.Text = "Cuenta origen: (seleccionada desde el menú principal)";
            }
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void BtnSiguienteConfirmacion_Click(object sender, EventArgs e)
        {

            var cuentaSeleccionada = this.CuentaOrigen;
            if (cuentaSeleccionada == null)
            {
                MessageBox.Show("Seleccione la cuenta origen desde el Menú principal antes de realizar la transacción.");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtCuentaDestino.Text))
            {
                MessageBox.Show("Ingrese la cuenta destino.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Ingrese el monto a enviar.");
                return;
            }


            string raw = txtMonto.Text.Replace("$", "").Replace(",", "").Trim();

            if (!decimal.TryParse(raw, out decimal monto))
            {
                MessageBox.Show("El monto debe ser numérico (formato en dólares). Ej: $1234.56");
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor que cero.");
                return;
            }

            // Verificar cuenta destino
            var db = new Datos.Database();
            var cuentaDestino = db.VerificarDestino(txtCuentaDestino.Text.Trim());
            if (cuentaDestino == null)
            {
                MessageBox.Show("La cuenta destino no existe.");
                return;
            }

            // Verificar saldo suficiente
            if (cuentaSeleccionada.saldo < monto)
            {
                MessageBox.Show("Fondos insuficientes.");
                return;
            }

            // Todo ok: abrir confirmación
            Confirmacion conf = new Confirmacion(cuentaSeleccionada.id, cuentaDestino.id, monto, cuentaSeleccionada.num_cuenta, cuentaDestino.num_cuenta, cuentaDestino.usuario_id);
            var dialog = conf.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
