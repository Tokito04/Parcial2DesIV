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
                    FinalForm final = new FinalForm(resultado);
                    final.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
                else
                {
                    // Si la BD no devolvió resultado, permitir simulación para pruebas locales
                    
                    MessageBox.Show("Error al procesar la transacción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la transacción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
