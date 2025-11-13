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
    public partial class Cierre : Form
    {
        public Cierre()
        {
            InitializeComponent();

            // Ajustar mensaje por defecto
            lblCerrarSesionMensaje.Text = "¿Desea cerrar sesión?";

            // Enlazar los eventos de los botones
            btnCerrarSesionSi.Click -= BtnCerrarSesionSi_Click;
            btnCerrarSesionSi.Click += BtnCerrarSesionSi_Click;

            btnCerrarSesionNo.Click -= BtnCerrarSesionNo_Click;
            btnCerrarSesionNo.Click += BtnCerrarSesionNo_Click;
        }

        private void BtnCerrarSesionSi_Click(object sender, EventArgs e)
        {
            // Confirmar cierre de sesión y cerrar formulario
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnCerrarSesionNo_Click(object sender, EventArgs e)
        {
            // Cancelar cierre de sesión
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
