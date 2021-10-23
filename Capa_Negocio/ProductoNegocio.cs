using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using Capa_entidad;

namespace Capa_Negocio
{
    public class ProductoNegocio
    {
        ProductosMetodos objProdMetodos = new ProductosMetodos();
        public Boolean grabarPrducto(Producto prod)
        {
            Boolean result = objProdMetodos.NuevoProducto(prod);
            return result;
        }
    }
}
