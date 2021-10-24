using System;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Presentacion
{
    public partial class Productos : Form
    {
        private object prod_Talle;

        public Productos()
        {
            InitializeComponent();
        }

        private void cBox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {


            int tipoProd = cBox_TipoProd.SelectedIndex;
            if (cmbEstado.SelectedItem.ToString() == "Outlet")
            {
                cmbUbiDepo.Items.Add("PA-Estante 5");
                switch (tipoProd)
                {
                    case 1://abrigos
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Gaban");
                        cbox_SubtipoProd.Items.Add("Montgomery");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 2://accesosrios
                        cbox_SubtipoProd.Items.Clear();
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
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Urbano");
                        cbox_SubtipoProd.Items.Add("Vestir c/cordones");
                        cbox_SubtipoProd.Items.Add("Vestir s/cordones");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 4://camisas manga corta
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 5://camisas manga larga
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 6://camperas
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuero");
                        cbox_SubtipoProd.Items.Add("Inflables");
                        cbox_SubtipoProd.Items.Add("Parkas");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 7://pantalon corto
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Malla");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 8://pantalon largo
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 9://remera
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello Base");
                        cbox_SubtipoProd.Items.Add("Cuello pique");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;

                    case 10://sastreria
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Ambo");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 11://sastreria
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Saco");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;
                    case 12://Sweaters
                        cbox_SubtipoProd.Items.Clear();
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
            else
            {

                switch (tipoProd)
                {
                    case 1://abrigos
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Gaban");
                        cbox_SubtipoProd.Items.Add("Montgomery");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PB-Perchero 1");
                        break;
                    case 2://accesosrios
                        cbox_SubtipoProd.Items.Clear();
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
                        cmbUbiDepo.Items.Add("PA-Estante 4");
                        break;
                    case 3: //Ambo
                        cbox_SubtipoProd.Enabled = true;
                        cmbUbiDepo.Items.Clear();
                        cmbUbiDepo.Items.Add("PB-Perchero 3");
                        break;

                    case 4://calzado
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Urbano");
                        cbox_SubtipoProd.Items.Add("Vestir c/cordones");
                        cbox_SubtipoProd.Items.Add("Vestir s/cordones");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PA-Estante 4");
                        break;
                    case 5://camisas manga corta
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PA-Estante 3");
                        break;
                    case 6://camisas manga larga
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PA-Estante 2");
                        break;
                    case 7://camperas
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuero");
                        cbox_SubtipoProd.Items.Add("Inflables");
                        cbox_SubtipoProd.Items.Add("Parkas");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PB-Perchero 1");
                        break;
                    case 8://pantalon corto
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Malla");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PB-Estante 2");
                        break;
                    case 9://pantalon largo
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Malla");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PB-Estante 2");
                        break;
                    case 10://remera
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello Base");
                        cbox_SubtipoProd.Items.Add("Cuello pique");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PA-Estante 3");
                        break;

                    case 11://saco
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Ambo");
                        cbox_SubtipoProd.Items.Add("Saco");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        
                        break;
                        //cmbUbiDepo.Items.Add("PB-Perchero 2"); break;
                    case 12://Sweaters
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello en V Algodon");
                        cbox_SubtipoProd.Items.Add("Cuello en V Bremer");
                        cbox_SubtipoProd.Items.Add("Cuello redondo Algodon");
                        cbox_SubtipoProd.Items.Add("Cuello redondo Bremer");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        cmbUbiDepo.Items.Add("PB-Estante 1");
                        break;
                    default:
                        break;
                }
            }

        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void cmbTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ta = cmbTalle.SelectedIndex;

            switch (ta)
            {
                case 1:
                    cmbTalle.Items.Add("36");
                    break;
                case 2:
                    cmbTalle.Items.Add("38");
                    break;
                case 3:
                    cmbTalle.Items.Add("40");
                    break;
                case 4:
                    cmbTalle.Items.Add("42");
                    break;
                case 5:
                    cmbTalle.Items.Add("44");
                    break;
                case 6:
                    cmbTalle.Items.Add("46");
                    break;
                case 7:
                    cmbTalle.Items.Add("48");
                    break;
                case 8:
                    cmbTalle.Items.Add("50");
                    break;
                default:
                    break;

            }
        }

        private void cmbUbiDepo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarNuevoArt_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta generando una nuevo Producto, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var productosNegocio = new ProductoNegocio();
            var prodEnt = new Productos();

            String tipoProducto = "";
            String subTipo = "";
            String codProducto = "";
            String temporada = "";
            object yourDateTime = null;
            String anio = yourDateTime.ToString().Substring(2);//DateTime.Now.ToString("yy");

            if ((resp == DialogResult.Yes))
            {
                prodEnt.prod_Talle = cmbTalle.Text;

                if (cBox_TipoProd.SelectedItem.ToString() == "Accesorios")
                {
                    prodEnt.prod_Talle = "ST";
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un talle para el producto!", "Seleccione Talle");
                }
            }
            if (cmbTeporada.SelectedItem.ToString()== "Primavera-Verano")
            {
                temporada = "V";
            }
            else
            {
                temporada = "I";
            }
             
            

        }
    }
}
