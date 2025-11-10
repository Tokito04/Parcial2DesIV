using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2DesIV.Modelos
{
    public class HistorialTransaccion
    {
        DateTime fecha { get; set; }
        string cuenta_origen { get; set; }
        string cuenta_destino { get; set; }
        string destinatario { get; set; }
        decimal monto { get; set; }
    }
}
