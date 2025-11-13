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
    public partial class FinalForm : Form
    {
        public FinalForm(Modelos.ResultadoTransaccion resultado)
        {
            InitializeComponent();
            lblDestinatario.Text += resultado.destinatario;
            lblMonto.Text += resultado.monto.ToString("C2");
            lblFecha.Text += resultado.fecha.ToString("g");
            lblDestino.Text += resultado.cuenta_destino;
            lblOrigen.Text += resultado.cuenta_origen;

            // Cuando este formulario se cierre, intentar mostrar el MenuPrincipal si existe
            this.FormClosed -= FinalForm_FormClosed;
            this.FormClosed += FinalForm_FormClosed;
        }

        private void FinalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Buscar una instancia abierta de MenuPrincipal y mostrarla
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is MenuPrincipal menu)
                    {
                        if (!menu.Visible)
                        {
                            menu.Show();
                        }
                        menu.BringToFront();
                        return;
                    }
                }
            }
            catch
            {
                // No hacer nada si ocurre un error; no interrumpir el cierre del diálogo
            }
        }
    }
}
