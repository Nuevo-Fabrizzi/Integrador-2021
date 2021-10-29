using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void lbl_RazonSocial_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModifProv_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
        }

        private void ProductosListado_Load(object sender, EventArgs e)
        {
            var prodMet = new ProductoNegocio();
            var dt2 = new DataTable();
            dt2 = prodMet.ConsultarProducto();
           
           
            if (dt2.Rows.Count != 0)
            {
                dgv_ListProductos.DataSource = dt2; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
            int tipoProd = cBox_TipoProd.SelectedIndex;
            switch (tipoProd)
            {
                case 1://abrigos
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Gaban");
                    cbox_SubtipoProd.Items.Add("Montgomery");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 2://accesosrios
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Cinto");
                    cbox_SubtipoProd.Items.Add("Corbata");
                    cbox_SubtipoProd.Items.Add("Corbatín");
                    cbox_SubtipoProd.Items.Add("Gemelos");
                    cbox_SubtipoProd.Items.Add("Moños");
                    cbox_SubtipoProd.Items.Add("Pañuelo");
                    cbox_SubtipoProd.Items.Add("Tiradores");
                    cbox_SubtipoProd.Items.Add("Traba corbata");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 3://calzado
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Urbano");
                    cbox_SubtipoProd.Items.Add("Vestir c/cordones");
                    cbox_SubtipoProd.Items.Add("Vestir s/cordones");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 4://camisas manga corta
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Fantasia");
                    cbox_SubtipoProd.Items.Add("Vestir");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 5://camisas manga larga
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Fantasia");
                    cbox_SubtipoProd.Items.Add("Vestir");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 6://camperas
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Cuero");
                    cbox_SubtipoProd.Items.Add("Inflables");
                    cbox_SubtipoProd.Items.Add("Parkas");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 7://pantalon corto
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Chino");
                    cbox_SubtipoProd.Items.Add("Jean");
                    cbox_SubtipoProd.Items.Add("Jogging");
                    cbox_SubtipoProd.Items.Add("Malla");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 8://pantalon largo
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Chino");
                    cbox_SubtipoProd.Items.Add("Jean");
                    cbox_SubtipoProd.Items.Add("Jogging");
                    cbox_SubtipoProd.Items.Add("Malla");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 9://remera
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Cuello Base");
                    cbox_SubtipoProd.Items.Add("Cuello pique");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;

                case 10://sastreria
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Ambo");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 11://sastreria
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Saco");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 12://Sweaters
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Cuello en V Algodon");
                    cbox_SubtipoProd.Items.Add("Cuello en V Bremer");
                    cbox_SubtipoProd.Items.Add("Cuello redondo Algodon");
                    cbox_SubtipoProd.Items.Add("Cuello redondo Bremer");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
           

        }

        private void cbox_SubtipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            String varSubTip = "";
            varSubTip = cbox_SubtipoProd.SelectedValue.ToString();
        }

        private void btn_VtaProd_Click(object sender, EventArgs e)
        {
            Ventas vent = new Ventas();
            vent.Show();
        }
    }
}
