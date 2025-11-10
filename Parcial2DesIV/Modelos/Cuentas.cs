using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2DesIV.Modelos
{
    public class Cuentas
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int usuario_id { get; set; }
        public string num_cuenta { get; set; } 
        public decimal saldo { get; set; }
    }
}
