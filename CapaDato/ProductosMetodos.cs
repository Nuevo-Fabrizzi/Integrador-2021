
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using CapaEntidad;
using Capa_entidad;

namespace Capa_Datos
{
    public class ProductosMetodos : Conexion
    {
        public Boolean NuevoProducto(ProductoEntidad producto)
        {

            DateTime fecha = DateTime.Now;
            String anio = DateTime.Now.Year.ToString();
            try
            {
                var sel = "set dateformat dmy insert into Productos(prod_CodDeProd, prod_Descripción, prod_Talle, prod_Tipo, prod_UbicEnDepo, prod_Cantidad, prod_StockMin, prod_StockMax, prod_Estado, prod_Temporada, prod_Fecha, prod_Anio)" +
                   " values('" + producto.prod_CodDeProd + "', '" + producto.prod_Descripción + "','" + producto.prod_Talle + "','" + producto.prod_Tipo + "','" + producto.prod_UbicEnDepo + "','" + producto.prod_Cantidad + "','" + producto.prod_StockMin + "','" + producto.prod_StockMax + "','" + producto.prod_Estado + "','" + producto.prod_Temporada + "','" + fecha + "','" + anio + "')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

    }
}

