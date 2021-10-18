using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UbicacionEnDeposito localizacion = new UbicacionEnDeposito();
            localizacion.Show();
        }

       

        private void cBox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoProd = cBox_TipoProd.SelectedIndex;


            switch (tipoProd)
            {
                case 1:
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Gaban");
                    cbox_SubtipoProd.Items.Add("Montgomery");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 2:
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
                case 3:
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Urbano");
                    cbox_SubtipoProd.Items.Add("Vestir c/cordones");
                    cbox_SubtipoProd.Items.Add("Vestir s/cordones");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 4:
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Manga corta-Fantasia");
                    cbox_SubtipoProd.Items.Add("Manga corta-Vestir");
                    cbox_SubtipoProd.Items.Add("Manga larga-Fantasia");
                    cbox_SubtipoProd.Items.Add("Manga larga-Vestir");
                    
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 5:
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Cuero");
                    cbox_SubtipoProd.Items.Add("Inflables");
                    cbox_SubtipoProd.Items.Add("Parkas");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 6://pantalon corto
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Chino");
                    cbox_SubtipoProd.Items.Add("Jean");
                    cbox_SubtipoProd.Items.Add("Jogging");
                    cbox_SubtipoProd.Items.Add("Malla");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 7://pantalon largo
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Chino");
                    cbox_SubtipoProd.Items.Add("Jean");
                    cbox_SubtipoProd.Items.Add("Jogging");
                    cbox_SubtipoProd.Items.Add("Malla");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 8://remera
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Cuello Base");
                    cbox_SubtipoProd.Items.Add("Cuello pique");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;

                case 9://sastreria
                    cbox_SubtipoProd.Items.Add("Seleccione");
                    cbox_SubtipoProd.Items.Add("Ambo");
                    cbox_SubtipoProd.Items.Add("Saco");
                    cbox_SubtipoProd.SelectedIndex = 0;
                    break;
                case 10://Sweaters
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

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
