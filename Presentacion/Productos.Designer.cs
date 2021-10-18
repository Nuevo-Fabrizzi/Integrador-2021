
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_SubtipoProd
            // 
            this.cbox_SubtipoProd.FormattingEnabled = true;
            this.cbox_SubtipoProd.Location = new System.Drawing.Point(179, 178);
            this.cbox_SubtipoProd.Name = "cbox_SubtipoProd";
            this.cbox_SubtipoProd.Size = new System.Drawing.Size(195, 21);
            this.cbox_SubtipoProd.TabIndex = 105;
            // 
            // lbl_subtipo
            // 
            this.lbl_subtipo.AutoSize = true;
            this.lbl_subtipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_subtipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_subtipo.Location = new System.Drawing.Point(108, 178);
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
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(230, 377);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 102;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Seleccionar ubición";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            "Calzados",
            "Camisas",
            "Camperas",
            "Pantalones Bermudas",
            "Pantalones Largos",
            "Remeras",
            "Sastreria",
            "Sweaters",
            "Otros"});
            this.cBox_TipoProd.Location = new System.Drawing.Point(179, 138);
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
            this.lbl_Tipo.Location = new System.Drawing.Point(122, 138);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(42, 17);
            this.lbl_Tipo.TabIndex = 97;
            this.lbl_Tipo.Text = "Tipo:";
            // 
            // tBox_Desc
            // 
            this.tBox_Desc.Location = new System.Drawing.Point(179, 324);
            this.tBox_Desc.Name = "tBox_Desc";
            this.tBox_Desc.Size = new System.Drawing.Size(229, 20);
            this.tBox_Desc.TabIndex = 96;
            // 
            // tBox_CodArt
            // 
            this.tBox_CodArt.Location = new System.Drawing.Point(199, 92);
            this.tBox_CodArt.Name = "tBox_CodArt";
            this.tBox_CodArt.Size = new System.Drawing.Size(195, 20);
            this.tBox_CodArt.TabIndex = 95;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Desc.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Desc.Location = new System.Drawing.Point(71, 327);
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
            this.lbl_CodArt.Location = new System.Drawing.Point(43, 95);
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
            "De Confección",
            "De Corte",
            "Maquinarias",
            "Otros"});
            this.cmbTalle.Location = new System.Drawing.Point(179, 224);
            this.cmbTalle.Name = "cmbTalle";
            this.cmbTalle.Size = new System.Drawing.Size(195, 21);
            this.cmbTalle.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(118, 224);
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
            this.label2.Location = new System.Drawing.Point(58, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "Ubicación en Depósito:";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(179, 275);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(195, 20);
            this.txtCantidadProd.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(96, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Cantidad";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_SubtipoProd);
            this.Controls.Add(this.lbl_subtipo);
            this.Controls.Add(this.CargarNuevoArt);
            this.Controls.Add(this.linkLabel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_SubtipoProd;
        public System.Windows.Forms.Label lbl_subtipo;
        public System.Windows.Forms.Button CargarNuevoArt;
        private System.Windows.Forms.LinkLabel linkLabel1;
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
    }
}