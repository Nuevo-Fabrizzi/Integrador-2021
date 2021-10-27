﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;
using System.Data.SqlClient;

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
        public DataTable ConsultarProducto()
        {
              return objProdMetodos.ConsultarProducto();
        }

        public DataTable ConsultarProdXTipo(Producto prod_Tipo)
        {
            return objProdMetodos.ConsultarProdXTipo(prod_Tipo);
        }

      
    }
}
