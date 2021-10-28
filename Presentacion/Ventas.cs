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

        string productoNuevo = "";

        private void Ventas_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        DateTime fecha = DateTime.Now;
        void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
           
            ProductoNegocio item = new ProductoNegocio();
            dt = item.ConsultarProducto();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               // lista.Add(dt.Rows[i]["prod_CodDeProd"].ToString());
               lista.Add(dt.Rows[i]["prod_Tipo"].ToString());
            }
            txtCodProd.AutoCompleteCustomSource = lista;
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

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {
            productoNuevo = txtCodProd.Text; 
        }

        private void btn_NuevaVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea generar una nueva venta?", "Una nueva venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        }
    }
}
