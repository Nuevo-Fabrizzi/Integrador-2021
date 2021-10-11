using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using CapaEntidad;
using System.Data;

namespace Capa_Negocio
{
    public class LoginNegocio
    {
        LoginMetodo objLoginMetodo = new LoginMetodo();

        public DataTable ConsultarLogin(string usu, string pas)
        {
            return objLoginMetodo.ConsultarLogin(usu , pas);
        }

        public int ultimoId()
        {
            int ultimoId = objLoginMetodo.ultimoId();

            return ultimoId;
         }

        public DataTable consultaNombre(string usu)
        {
            return objLoginMetodo.consultaNombre(usu);
        }
    }

    
}
