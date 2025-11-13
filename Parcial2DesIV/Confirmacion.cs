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
            lblNumeroCuentaOrigen.Text = numeroOrigen;
            lblNumeroCuentaDestino.Text = numeroDestino;
            lblMontoEnviar.Text = monto.ToString("C2");
            lblNombreUsuario.Text = "Usuario destino ID: " + usuarioDestinoId.ToString();
            btnVolver.Click -= BtnVolver_Click;
            btnVolver.Click += BtnVolver_Click;
            btnConfirmar.Click -= BtnConfirmar_Click;
            btnConfirmar.Click += BtnConfirmar_Click;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {

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
                    // Si la BD no devolvió resultado, permitir simulación para pruebas locales
                    var res = MessageBox.Show("No se obtuvo confirmación desde la base de datos. ¿Desea simular la transacción para pruebas?", "Simular transacción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Simulación: Transacción realizada con éxito.", "Éxito (simulado)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al procesar la transacción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error de BD, ofrecer simular la transacción para facilitar pruebas de UI
                var resp = MessageBox.Show("Error al procesar la transacción: " + ex.Message + "\n\n¿Desea simular la transacción para pruebas?", "Error (simulación)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    MessageBox.Show("Simulación: Transacción realizada con éxito.", "Éxito (simulado)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
