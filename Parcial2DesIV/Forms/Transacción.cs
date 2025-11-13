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
        private List<Modelos.Cuentas> cuentasTransaccion;

        public Transacción()
        {
            InitializeComponent();
            this.btnSiguienteConfirmacion.Click += BtnSiguienteConfirmacion_Click;
            // validar entrada del monto: permitir solo números, punto o coma y control
            this.txtMonto.KeyPress -= TxtMonto_KeyPress;
            this.txtMonto.KeyPress += TxtMonto_KeyPress;
        }

        public Transacción(List<Modelos.Cuentas> cuentasTransaccion) : this()
        {
            this.cuentasTransaccion = cuentasTransaccion;

            if (cuentasTransaccion != null)
            {
                // Mostrar el número de cuenta en el ComboBox
                cmbCuentaOrigen.DisplayMember = "num_cuenta";
                cmbCuentaOrigen.ValueMember = "id";
                cmbCuentaOrigen.DataSource = cuentasTransaccion;
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

            // Obtener el objeto Cuentas seleccionado desde SelectedItem
            var cuentaSeleccionada = cmbCuentaOrigen.SelectedItem as Modelos.Cuentas;
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
            if(txtCuentaDestino.Text.Trim() == cuentaSeleccionada.num_cuenta)
            {
                MessageBox.Show("La cuenta destino no puede ser la misma que la cuenta origen.");
                return;
            }


            string raw = txtMonto.Text.Replace("$", "").Replace(",", "").Trim();

            if (!decimal.TryParse(raw, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal monto))
            {
                // Intentar con la cultura actual si falla con Invariant
                if (!decimal.TryParse(raw, out monto))
                {
                    MessageBox.Show("El monto debe ser numérico (formato en dólares). Ej: $1234.56");
                    return;
                }
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
