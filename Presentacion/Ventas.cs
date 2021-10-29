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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            autocompletar();
        }



        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        void autocompletar()
        {
            //AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            //var ds = new DataSet();
            //DataTable dt = new DataTable();
            //ProductoNegocio item = new ProductoNegocio();
            //dt = item.ConsultarProducto();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    lista.Add(dt.Rows[i]["prod_CodDeProd"].ToString());
            //}
            //txtCodProd.AutoCompleteCustomSource = lista;
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtCodProd.TextLength.ToString() != "")
            {

            }
        }

       
    }
}
