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
        public String Tipo = "";
        Producto produ = new Producto();



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


            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //var ProdNego = new ProductoNegocio();
            //var prod = new Producto();
            //dt = ProdNego.ConsultarProductoTipo(prod);
            var dt = new DataTable();
            produ.prod_Tipo = cBox_TipoProd.Text;
            var ProdNego = new ProductoNegocio();
            dt = ProdNego.ConsultarProductoTipo(produ);
            
            if (dt.Rows.Count != 0)
            {

              



                dgv_ListProductos.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }

            //if (dt.Rows.Count != 0)
            //{
            //    dgv_ListProductos.DataSource = dt; //ds.Tables[0];

            //}
            //else
            //{
            //    MessageBox.Show("no hay productos disponibles para temporada, tipo y subtipo seleccionado");
            //}
        }






        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cBox_TipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo = cBox_TipoProd.Text;


        }

        private void ProductosListado_Load(object sender, EventArgs e)
        {
           
        }
    }
}
