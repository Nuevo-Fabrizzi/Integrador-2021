﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace Capa_Datos
{
    public class MateriasPrimasMetodos : Conexion
    {
        public Boolean grabarMatPri(MateriaPrima MatPri)
        {
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy insert into MateriasPrimas (mpri_CodArt,mpri_Descripcion,mpri_tipo ,mpri_CUITprov)" +
                   " VALUES ( '" + MatPri.mpri_CodArt + "','" + MatPri.mpri_Descripcion + "','" + MatPri.mpri_tipo + "','" + MatPri.mpri_CUITprov + "')";
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

        public DataTable ConsultarMateria(String CodArt)
        {
            var sqlStr = "select * from MateriasPrimas where mpri_CodArt = '" + CodArt + "';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarMateria()
        {
            var sqlStr = "select mpri_CodArt, mpri_Descripcion,mpri_tipo,mpri_Cantidad,p.pro_RazonSocial from MateriasPrimas m,Proveedores p where m.mpri_CUITprov =p.pro_CUIT ;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarMatPrimaporProv(String ProvRS)
        {
            var sqlStr = "select  mpri_CodArt, mpri_Descripcion,mpri_tipo,mpri_Cantidad,p.pro_RazonSocial from MateriasPrimas,Proveedores p where mpri_CUITprov = pro_CUIT and mpri_CUITprov ='" + ProvRS + "';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

    }
}
