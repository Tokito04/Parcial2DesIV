using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2DesIV.Modelos
{
    public class HistorialTransaccion
    {
        public DateTime fecha { get; set; }
        public string tipo { get; set; }
        public string cuenta_origen { get; set; }
        public string cuenta_destino { get; set; }
        public string contraparte { get; set; }
        public decimal monto { get; set; }
    }
}
