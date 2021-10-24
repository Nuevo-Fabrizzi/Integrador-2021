
namespace Presentacion
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox_SubtipoProd = new System.Windows.Forms.ComboBox();
            this.lbl_subtipo = new System.Windows.Forms.Label();
            this.CargarNuevoArt = new System.Windows.Forms.Button();
            this.btn_GuardarMatPri = new System.Windows.Forms.Button();
            this.cBox_TipoProd = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.tBox_Desc = new System.Windows.Forms.TextBox();
            this.tBox_CodArt = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_CodArt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitProv = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.cmbTalle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUbiDepo = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTeporada = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstantePerchero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_SubtipoProd
            // 
            this.cbox_SubtipoProd.FormattingEnabled = true;
            this.cbox_SubtipoProd.Location = new System.Drawing.Point(179, 221);
            this.cbox_SubtipoProd.Name = "cbox_SubtipoProd";
            this.cbox_SubtipoProd.Size = new System.Drawing.Size(195, 21);
            this.cbox_SubtipoProd.TabIndex = 105;
            // 
            // lbl_subtipo
            // 
            this.lbl_subtipo.AutoSize = true;
            this.lbl_subtipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_subtipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_subtipo.Location = new System.Drawing.Point(108, 221);
            this.lbl_subtipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtipo.Name = "lbl_subtipo";
            this.lbl_subtipo.Size = new System.Drawing.Size(64, 17);
            this.lbl_subtipo.TabIndex = 104;
            this.lbl_subtipo.Text = "Subtipo:";
            // 
            // CargarNuevoArt
            // 
            this.CargarNuevoArt.BackColor = System.Drawing.Color.SeaGreen;
            this.CargarNuevoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.CargarNuevoArt.ForeColor = System.Drawing.Color.White;
            this.CargarNuevoArt.Location = new System.Drawing.Point(478, 441);
            this.CargarNuevoArt.Name = "CargarNuevoArt";
            this.CargarNuevoArt.Size = new System.Drawing.Size(140, 39);
            this.CargarNuevoArt.TabIndex = 103;
            this.CargarNuevoArt.Text = "Cargar nuevo producto";
            this.CargarNuevoArt.UseVisualStyleBackColor = false;
            this.CargarNuevoArt.Click += new System.EventHandler(this.CargarNuevoArt_Click);
            // 
            // btn_GuardarMatPri
            // 
            this.btn_GuardarMatPri.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarMatPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarMatPri.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarMatPri.Location = new System.Drawing.Point(648, 441);
            this.btn_GuardarMatPri.Name = "btn_GuardarMatPri";
            this.btn_GuardarMatPri.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarMatPri.TabIndex = 100;
            this.btn_GuardarMatPri.Text = "Guardar y salir";
            this.btn_GuardarMatPri.UseVisualStyleBackColor = false;
            // 
            // cBox_TipoProd
            // 
            this.cBox_TipoProd.FormattingEnabled = true;
            this.cBox_TipoProd.Items.AddRange(new object[] {
            "Seleccione",
            "Abrigos",
            "Accesorios",
            "Ambos",
            "Calzados",
            "Camisas mangas cortas",
            "Camisas mangas largas",
            "Camperas",
            "Pantalones cortos",
            "Pantalones largos",
            "Remeras",
            "Sastreria",
            "Sweaters"});
            this.cBox_TipoProd.Location = new System.Drawing.Point(179, 181);
            this.cBox_TipoProd.Name = "cBox_TipoProd";
            this.cBox_TipoProd.Size = new System.Drawing.Size(195, 21);
            this.cBox_TipoProd.TabIndex = 98;
            this.cBox_TipoProd.SelectedIndexChanged += new System.EventHandler(this.cBox_Tipo_SelectedIndexChanged);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Tipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Tipo.Location = new System.Drawing.Point(122, 181);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(42, 17);
            this.lbl_Tipo.TabIndex = 97;
            this.lbl_Tipo.Text = "Tipo:";
            // 
            // tBox_Desc
            // 
            this.tBox_Desc.Location = new System.Drawing.Point(542, 138);
            this.tBox_Desc.Name = "tBox_Desc";
            this.tBox_Desc.Size = new System.Drawing.Size(229, 20);
            this.tBox_Desc.TabIndex = 96;
            // 
            // tBox_CodArt
            // 
            this.tBox_CodArt.Location = new System.Drawing.Point(179, 107);
            this.tBox_CodArt.Name = "tBox_CodArt";
            this.tBox_CodArt.Size = new System.Drawing.Size(195, 20);
            this.tBox_CodArt.TabIndex = 95;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Desc.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Desc.Location = new System.Drawing.Point(434, 141);
            this.lbl_Desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(91, 17);
            this.lbl_Desc.TabIndex = 94;
            this.lbl_Desc.Text = "Descripción:";
            // 
            // lbl_CodArt
            // 
            this.lbl_CodArt.AutoSize = true;
            this.lbl_CodArt.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CodArt.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CodArt.Location = new System.Drawing.Point(23, 110);
            this.lbl_CodArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodArt.Name = "lbl_CodArt";
            this.lbl_CodArt.Size = new System.Drawing.Size(139, 17);
            this.lbl_CodArt.TabIndex = 93;
            this.lbl_CodArt.Text = "Código de artículo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProv);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 86);
            this.panel1.TabIndex = 92;
            // 
            // lbl_TitProv
            // 
            this.lbl_TitProv.AutoSize = true;
            this.lbl_TitProv.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProv.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProv.Location = new System.Drawing.Point(301, 26);
            this.lbl_TitProv.Name = "lbl_TitProv";
            this.lbl_TitProv.Size = new System.Drawing.Size(262, 40);
            this.lbl_TitProv.TabIndex = 66;
            this.lbl_TitProv.Text = "Alta de productos";
            // 
            // btn_CerrarUsuAlta
            // 
            this.btn_CerrarUsuAlta.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarUsuAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CerrarUsuAlta.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarUsuAlta.Location = new System.Drawing.Point(774, 26);
            this.btn_CerrarUsuAlta.Name = "btn_CerrarUsuAlta";
            this.btn_CerrarUsuAlta.Size = new System.Drawing.Size(39, 23);
            this.btn_CerrarUsuAlta.TabIndex = 65;
            this.btn_CerrarUsuAlta.Text = "X";
            this.btn_CerrarUsuAlta.UseVisualStyleBackColor = false;
            this.btn_CerrarUsuAlta.Click += new System.EventHandler(this.btn_CerrarUsuAlta_Click);
            // 
            // cmbTalle
            // 
            this.cmbTalle.FormattingEnabled = true;
            this.cmbTalle.Items.AddRange(new object[] {
            "Seleccione",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50"});
            this.cmbTalle.Location = new System.Drawing.Point(179, 267);
            this.cmbTalle.Name = "cmbTalle";
            this.cmbTalle.Size = new System.Drawing.Size(195, 21);
            this.cmbTalle.TabIndex = 107;
            this.cmbTalle.SelectedIndexChanged += new System.EventHandler(this.cmbTalle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(118, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Talle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(421, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "Ubicación en Depósito:";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(179, 354);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(195, 20);
            this.txtCantidadProd.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(96, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Cantidad";
            // 
            // cmbUbiDepo
            // 
            this.cmbUbiDepo.FormattingEnabled = true;
            this.cmbUbiDepo.Location = new System.Drawing.Point(593, 187);
            this.cmbUbiDepo.Name = "cmbUbiDepo";
            this.cmbUbiDepo.Size = new System.Drawing.Size(195, 21);
            this.cmbUbiDepo.TabIndex = 111;
            this.cmbUbiDepo.SelectedIndexChanged += new System.EventHandler(this.cmbUbiDepo_SelectedIndexChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Seleccione",
            "Outlet",
            "Venta",
            "",
            "",
            ""});
            this.cmbEstado.Location = new System.Drawing.Point(179, 144);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(195, 21);
            this.cmbEstado.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(107, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "Estado";
            // 
            // cmbTeporada
            // 
            this.cmbTeporada.FormattingEnabled = true;
            this.cmbTeporada.Items.AddRange(new object[] {
            "Seleccione",
            "Primavera-Verano",
            "Otoño-Invierno"});
            this.cmbTeporada.Location = new System.Drawing.Point(179, 309);
            this.cmbTeporada.Name = "cmbTeporada";
            this.cmbTeporada.Size = new System.Drawing.Size(195, 21);
            this.cmbTeporada.TabIndex = 117;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(87, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 116;
            this.label6.Text = "Temporada";
            // 
            // cmbEstantePerchero
            // 
            this.cmbEstantePerchero.FormattingEnabled = true;
            this.cmbEstantePerchero.Items.AddRange(new object[] {
            "Seleccione",
            "Nivel 1",
            "Nivel 2",
            "Nivel 3",
            "Nivel 4",
            "Nivel 5"});
            this.cmbEstantePerchero.Location = new System.Drawing.Point(593, 219);
            this.cmbEstantePerchero.Name = "cmbEstantePerchero";
            this.cmbEstantePerchero.Size = new System.Drawing.Size(195, 21);
            this.cmbEstantePerchero.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(421, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 118;
            this.label4.Text = "Estante o Perchero";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seleccione",
            "01-Azul",
            "02-Azul Francia",
            "03-Azul Marino",
            "04-Beige",
            "05-Blanco",
            "06-Bordo",
            "07-Celeste",
            "08-Gris",
            "09-Lila",
            "10-Marron",
            "11-Marron Chocolate",
            "12-Negro",
            "13-Rojo",
            "14-Rosa",
            "15-Salmon"});
            this.comboBox1.Location = new System.Drawing.Point(179, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(116, 398);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 120;
            this.label7.Text = "Color";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEstantePerchero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTeporada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUbiDepo);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_SubtipoProd);
            this.Controls.Add(this.lbl_subtipo);
            this.Controls.Add(this.CargarNuevoArt);
            this.Controls.Add(this.btn_GuardarMatPri);
            this.Controls.Add(this.cBox_TipoProd);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.tBox_Desc);
            this.Controls.Add(this.tBox_CodArt);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_CodArt);
            this.Controls.Add(this.panel1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_SubtipoProd;
        public System.Windows.Forms.Label lbl_subtipo;
        public System.Windows.Forms.Button CargarNuevoArt;
        public System.Windows.Forms.Button btn_GuardarMatPri;
        private System.Windows.Forms.ComboBox cBox_TipoProd;
        public System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.TextBox tBox_Desc;
        private System.Windows.Forms.TextBox tBox_CodArt;
        public System.Windows.Forms.Label lbl_Desc;
        public System.Windows.Forms.Label lbl_CodArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProv;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        private System.Windows.Forms.ComboBox cmbTalle;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadProd;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUbiDepo;
        private System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTeporada;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstantePerchero;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label7;
    }
}