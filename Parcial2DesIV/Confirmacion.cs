using System;
using System.Windows.Forms;

namespace Parcial2DesIV
{
    public partial class Confirmacion : Form
    {
        private int idOrigen;
        private int idDestino;
        private decimal monto;
        private string numeroOrigen;
        private string numeroDestino;
        private int usuarioDestinoId;

        public Confirmacion(int idOrigen, int idDestino, decimal monto, string numeroOrigen, string numeroDestino, int usuarioDestinoId)
        {
            InitializeComponent();

            this.idOrigen = idOrigen;
            this.idDestino = idDestino;
            this.monto = monto;
            this.numeroOrigen = numeroOrigen;
            this.numeroDestino = numeroDestino;
            this.usuarioDestinoId = usuarioDestinoId;

            // Reescribir directamente los labels con la información de la transacción
            lblNumeroCuentaOrigen.Text = numeroOrigen;
            lblNumeroCuentaDestino.Text = numeroDestino;
            lblMontoEnviar.Text = monto.ToString("C2");
            lblNombreUsuario.Text = "Usuario destino ID: " + usuarioDestinoId.ToString();

            // Enlazar botones: btnVolver = Editar datos (volver), btnConfirmar = Confirmar
            btnVolver.Click -= BtnVolver_Click;
            btnVolver.Click += BtnVolver_Click;

            btnConfirmar.Click -= BtnConfirmar_Click;
            btnConfirmar.Click += BtnConfirmar_Click;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Volver al formulario anterior para editar datos
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Datos.Database();
                var resultado = db.RegistrarTransaccion(idOrigen, idDestino, monto, DateTime.Now);
                if (resultado != null)
                {
                    MessageBox.Show("Transacción realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al procesar la transacción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // permitir reintento o volver
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la transacción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
