using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2DesIV.Modelos
{
    public class Transacciones
    {
        public int id { get; set; }
        public string id_cuenta_origen { get; set; }
        public string id_cuenta_destino { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
    }
}
