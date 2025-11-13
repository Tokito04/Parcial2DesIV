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
    public partial class Transacción : Form
    {
        private Modelos.Cuentas CuentaOrigen;
        private Modelos.Usuarios UsuarioActual;

        public Transacción()
        {
            InitializeComponent();
            this.btnSiguienteConfirmacion.Click += BtnSiguienteConfirmacion_Click;
            this.Load += Transacción_Load;
        }

        public Transacción(Modelos.Cuentas cuentaOrigen) : this()
        {
            this.CuentaOrigen = cuentaOrigen;
            // Si se recibe cuenta origen, preseleccionarla en el combo
            if (cuentaOrigen != null)
            {
                lblCuentaOrigen.Text = $"Cuenta origen: {cuentaOrigen.num_cuenta} - {cuentaOrigen.nombre} (Saldo: {cuentaOrigen.saldo:C2})";
            }
        }

        public Transacción(Modelos.Usuarios usuario) : this()
        {
            this.UsuarioActual = usuario;
        }

        private void Transacción_Load(object sender, EventArgs e)
        {
            // Cargar cuentas del usuario en cboCuentaOrigen (si UsuarioActual existe)
            try
            {
                var db = new Datos.Database();
                List<Modelos.Cuentas> cuentas = new List<Modelos.Cuentas>();
                if (this.UsuarioActual != null)
                {
                    cuentas = db.ObtenerCuentasUsuario(this.UsuarioActual.id);
                }
                else if (this.CuentaOrigen != null)
                {
                    cuentas.Add(this.CuentaOrigen);
                }

                cboCuentaOrigen.DisplayMember = "num_cuenta";
                cboCuentaOrigen.ValueMember = "id";
                cboCuentaOrigen.DataSource = cuentas;

                if (this.CuentaOrigen != null)
                {
                    // seleccionar la cuenta recibida
                    for (int i = 0; i < cboCuentaOrigen.Items.Count; i++)
                    {
                        var c = cboCuentaOrigen.Items[i] as Modelos.Cuentas;
                        if (c != null && c.id == this.CuentaOrigen.id)
                        {
                            cboCuentaOrigen.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuentas origen: " + ex.Message);
            }
        }

        private void BtnSiguienteConfirmacion_Click(object sender, EventArgs e)
        {
            // Obtener cuenta origen seleccionada
            var cuentaSeleccionada = cboCuentaOrigen.SelectedItem as Modelos.Cuentas;
            if (cuentaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una cuenta origen.");
                return;
            }

            // Validaciones
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

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("El monto debe ser numérico.");
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
