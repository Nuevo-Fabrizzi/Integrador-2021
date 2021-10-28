using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class NotaDeVenta
    {
        public int Ndv_IdNotaDeVenta { get; set; }
        public decimal Ndv_MontoTotal { get; set; }
        public DateTime Ndv_FechaDeVenta { get; set; }
        public int Ndv_IdDeVenta { get; set; }
    }
}
