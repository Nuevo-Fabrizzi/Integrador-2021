using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class DetalleVenta
    {
        public int Deta_IdVenta { get; set; }
        public String Deta_CodDeProd { get; set; }
        public int Deta_cantProdu { get; set; }
        public decimal Deta_PrecioUnitario { get; set; }
    }
}
