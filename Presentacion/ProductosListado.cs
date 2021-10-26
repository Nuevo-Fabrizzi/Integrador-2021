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
        public String subTipo = "";
        String pTemp = "";
        private object prod_CodDeProd;

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
            var pro = new Producto();
            dt = ProdNego.ConsultarProductoTemporada(pro);


            if (dt.Rows.Count != 0)
            {
                dgv_ListProductos.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                //if (dt1.Rows.Count != 0)
                //{
                //    dgv_ListProductos.DataSource = dt1;
                //}

                //MessageBox.Show("No hay datos registados.");
            }
        }

        public void cBox_ProductoTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            //DataSet ds 
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

        public void cBox_TipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public void cbox_subitpoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tipo = cBox_TipoProd.SelectedValue.ToString();
            //subTipo = cbox_subtipoProd.SelectedValue.ToString();
            int tipoProd = cBox_TipoProd.SelectedIndex;
            switch (tipoProd)
            {
                case 1://abrigos
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Gaban");
                    cbox_subtipoProd.Items.Add("Montgomery");
                    cbox_subtipoProd.SelectedIndex = 0;
                    //Tipo = cBox_TipoProd.SelectedValue.ToString();
                    //subTipo = cbox_subtipoProd.SelectedValue.ToString();
                    break;
                case 2://accesosrios
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cinto");
                    cbox_subtipoProd.Items.Add("Corbata");
                    cbox_subtipoProd.Items.Add("Corbatín");
                    cbox_subtipoProd.Items.Add("Gemelos");
                    cbox_subtipoProd.Items.Add("Moños");
                    cbox_subtipoProd.Items.Add("Pañuelo");
                    cbox_subtipoProd.Items.Add("Tiradores");
                    cbox_subtipoProd.Items.Add("Traba corbata");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 3://calzado
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Urbano");
                    cbox_subtipoProd.Items.Add("Vestir c/cordones");
                    cbox_subtipoProd.Items.Add("Vestir s/cordones");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 4://camisas manga corta
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Fantasia");
                    cbox_subtipoProd.Items.Add("Vestir");
                    cbox_subtipoProd.SelectedIndex = 0;
                    Tipo = cBox_TipoProd.SelectedValue.ToString();
                    subTipo = cbox_subtipoProd.SelectedValue.ToString();
                    break;
                case 5://camisas manga larga
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Fantasia");
                    cbox_subtipoProd.Items.Add("Vestir");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 6://camperas
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cuero");
                    cbox_subtipoProd.Items.Add("Inflables");
                    cbox_subtipoProd.Items.Add("Parkas");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 7://pantalon corto
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Chino");
                    cbox_subtipoProd.Items.Add("Jean");
                    cbox_subtipoProd.Items.Add("Jogging");
                    cbox_subtipoProd.Items.Add("Malla");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 8://pantalon largo
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Chino");
                    cbox_subtipoProd.Items.Add("Jean");
                    cbox_subtipoProd.Items.Add("Jogging");
                    cbox_subtipoProd.Items.Add("Vestir");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 9://remera
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cuello Base");
                    cbox_subtipoProd.Items.Add("Cuello pique");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;

                case 10://sastreria
                        // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Ambo");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 11://sastreria
                        // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Saco");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 12://Sweaters
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cuello en V Algodon");
                    cbox_subtipoProd.Items.Add("Cuello en V Bremer");
                    cbox_subtipoProd.Items.Add("Cuello redondo Algodon");
                    cbox_subtipoProd.Items.Add("Cuello redondo Bremer");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }

        public void ProductosListado_Load(object sender, EventArgs e)
        {
            //var produ = new ProductoNegocio();
            //var dt = new DataTable();
            //dt = produ.ConsultarProducto();
            //// cboxTemporada.DataSource = produ.ConsultarProductoTemporada();
            //if (dt.Rows.Count = !0)
            //{
            //    DataRow fila = dt.NewRow();
            //    fila["prod_Tipo"]
            //}
            int tipoProd = cBox_TipoProd.SelectedIndex;
            switch (tipoProd)
            {
                case 1://abrigos
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Gaban");
                    cbox_subtipoProd.Items.Add("Montgomery");
                   // cbox_subtipoProd.SelectedIndex = 0;
                    //Tipo = cBox_TipoProd.SelectedValue.ToString();
                    //subTipo = cbox_subtipoProd.SelectedValue.ToString();
                    break;
                case 2://accesosrios
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cinto");
                    cbox_subtipoProd.Items.Add("Corbata");
                    cbox_subtipoProd.Items.Add("Corbatín");
                    cbox_subtipoProd.Items.Add("Gemelos");
                    cbox_subtipoProd.Items.Add("Moños");
                    cbox_subtipoProd.Items.Add("Pañuelo");
                    cbox_subtipoProd.Items.Add("Tiradores");
                    cbox_subtipoProd.Items.Add("Traba corbata");
                   // cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 3://calzado
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Urbano");
                    cbox_subtipoProd.Items.Add("Vestir c/cordones");
                    cbox_subtipoProd.Items.Add("Vestir s/cordones");
                    ///cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 4://camisas manga corta
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Fantasia");
                    cbox_subtipoProd.Items.Add("Vestir");
                   // cbox_subtipoProd.SelectedIndex = 0;
                    //Tipo = cBox_TipoProd.SelectedValue.ToString();
                    //subTipo = cbox_subtipoProd.SelectedValue.ToString();
                    break;
                case 5://camisas manga larga
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Fantasia");
                    cbox_subtipoProd.Items.Add("Vestir");
                   // cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 6://camperas
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cuero");
                    cbox_subtipoProd.Items.Add("Inflables");
                    cbox_subtipoProd.Items.Add("Parkas");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 7://pantalon corto
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Chino");
                    cbox_subtipoProd.Items.Add("Jean");
                    cbox_subtipoProd.Items.Add("Jogging");
                    cbox_subtipoProd.Items.Add("Malla");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 8://pantalon largo
                       // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Chino");
                    cbox_subtipoProd.Items.Add("Jean");
                    cbox_subtipoProd.Items.Add("Jogging");
                    cbox_subtipoProd.Items.Add("Vestir");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 9://remera
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cuello Base");
                    cbox_subtipoProd.Items.Add("Cuello pique");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;

                case 10://sastreria
                        // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Ambo");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 11://sastreria
                        // cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Saco");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                case 12://Sweaters
                    //cbox_subtipoProd.Items.Clear();
                    cbox_subtipoProd.Items.Add("Seleccione");
                    cbox_subtipoProd.Items.Add("Cuello en V Algodon");
                    cbox_subtipoProd.Items.Add("Cuello en V Bremer");
                    cbox_subtipoProd.Items.Add("Cuello redondo Algodon");
                    cbox_subtipoProd.Items.Add("Cuello redondo Bremer");
                    cbox_subtipoProd.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
