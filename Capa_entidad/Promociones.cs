using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Promociones
    {
        public int Prom_IdPromocion { get; set; }
        public DateTime Prom_FechaInicio { get; set; }
        public DateTime Prom_FechaFin { get; set; }
        public String Prom_EstadoPromo { get; set; }
    }
}
