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
    public partial class Historial : Form
    {
        public Modelos.Usuarios UsuarioActual { get; set; }

        public Historial()
        {
            InitializeComponent();
            this.Load += Historial_Load;
        }

        public Historial(Modelos.Usuarios usuario) : this()
        {
            this.UsuarioActual = usuario;
        }

        public Historial(int idUsuario) : this()
        {

            this.UsuarioActual = new Modelos.Usuarios { id = idUsuario };
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.UsuarioActual == null || this.UsuarioActual.id <= 0)
                {
                    return;
                }

                var db = new Datos.Database();
                List<Modelos.HistorialTransaccion> transacciones = db.ObtenerTransaccionesUsuario(this.UsuarioActual.id);
                dgvTransacciones.AutoGenerateColumns = true;
                dgvTransacciones.DataSource = transacciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }
    }
}
