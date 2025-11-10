using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2DesIV.Modelos
{
    public class ResultadoTransaccion
    {
        public string mensaje { get; set; }
        public string cuenta_origen { get; set; }
        public string cuenta_destino { get; set; }
        public string destinatario { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
    }
}
