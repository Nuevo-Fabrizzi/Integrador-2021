using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Local
    {
        public String Nombre { get; set; }
        public int IdLocal { get; set; }
        public String Oulet { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String Fabrica { get; set; }
        public DateTime FechaAlta { get; set; }//
        public DateTime FechaBaja { get; set; }//
        public DateTime FechaModificacion { get; set; }//
    }
}
