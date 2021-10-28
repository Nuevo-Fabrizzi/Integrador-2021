using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Ventas
    {
        public int Vta_IdDeVenta { get; set; }
        public decimal Vta_Monto { get; set; }
        public String Vta_TipoVenta { get; set; }
        public int Vta_IdLoc { get; set; }
        public int Vta_TiposDePago { get; set; }
        public int Vta_Promociones { get; set; }
        public DateTime Vta_fecha { get; set; }
    }
}
