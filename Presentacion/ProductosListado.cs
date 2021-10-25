using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Presentacion
{
    public partial class ProductosListado : Form
    {
        public ProductosListado()
        {
            InitializeComponent();
        }

        String pTemp = "";

        public string PTemp { get => pTemp; set => pTemp = value; }

        private void btn_ModifProv_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
        }



        private void dgv_ListProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btn_BuscarProducto_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            var ProdNego = new ProductoNegocio();
            Producto prod_CodDeProd = null;
            dt = ProdNego.ConsultarProductoTemporada(prod_CodDeProd) ;

            if (dt.Rows.Count != 0)
            {
                dgv_ListProductos.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        public void cBox_ProductoTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            Otoño - Invierno
            //Primavera - Verano
            pTemp = cboxTemporada.SelectedText;
            if (cboxTemporada.SelectedItem.ToString() == "Primavera - Verano")
            {
                pTemp = "V";
            }
            else
            {
                
                    pTemp = "I";
            }
        }
    }
}
