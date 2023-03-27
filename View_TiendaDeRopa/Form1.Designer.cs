namespace View_TiendaDeRopa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LNombreTienda = new Label();
            LDireccionTienda = new Label();
            LNombreVendedor = new Label();
            LCodigoVendedor = new Label();
            LHistorial = new Label();
            GBPrenda = new GroupBox();
            panel3 = new Panel();
            RBChupin = new RadioButton();
            RBComun = new RadioButton();
            panel2 = new Panel();
            RBCuelloMao = new RadioButton();
            RBCuelloComun = new RadioButton();
            panel1 = new Panel();
            RBMangaLarga = new RadioButton();
            RBMangaCorta = new RadioButton();
            RBPantalon = new RadioButton();
            RBCamisa = new RadioButton();
            GBCalidad = new GroupBox();
            RBPremium = new RadioButton();
            RBStandard = new RadioButton();
            BDisponibilidad = new Button();
            LStock = new Label();
            groupBox1 = new GroupBox();
            TBCantidad = new TextBox();
            LCantidad = new Label();
            TBPrecio = new TextBox();
            LPesos = new Label();
            BCotizar = new Button();
            LPrecioFinal = new Label();
            timer = new System.Windows.Forms.Timer(components);
            GBPrenda.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            GBCalidad.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LNombreTienda
            // 
            LNombreTienda.AutoSize = true;
            LNombreTienda.Location = new Point(9, 15);
            LNombreTienda.Name = "LNombreTienda";
            LNombreTienda.Size = new Size(117, 15);
            LNombreTienda.TabIndex = 0;
            LNombreTienda.Text = "Nombre de la Tienda";
            // 
            // LDireccionTienda
            // 
            LDireccionTienda.AutoSize = true;
            LDireccionTienda.Location = new Point(165, 15);
            LDireccionTienda.Name = "LDireccionTienda";
            LDireccionTienda.Size = new Size(123, 15);
            LDireccionTienda.TabIndex = 1;
            LDireccionTienda.Text = "Direccion de la Tienda";
            // 
            // LNombreVendedor
            // 
            LNombreVendedor.AutoSize = true;
            LNombreVendedor.Location = new Point(9, 47);
            LNombreVendedor.Name = "LNombreVendedor";
            LNombreVendedor.Size = new Size(123, 15);
            LNombreVendedor.TabIndex = 2;
            LNombreVendedor.Text = "Nombre del Vendedor";
            // 
            // LCodigoVendedor
            // 
            LCodigoVendedor.AutoSize = true;
            LCodigoVendedor.Location = new Point(165, 47);
            LCodigoVendedor.Name = "LCodigoVendedor";
            LCodigoVendedor.Size = new Size(118, 15);
            LCodigoVendedor.TabIndex = 3;
            LCodigoVendedor.Text = "Código del Vendedor";
            // 
            // LHistorial
            // 
            LHistorial.AutoSize = true;
            LHistorial.Location = new Point(313, 47);
            LHistorial.Name = "LHistorial";
            LHistorial.Size = new Size(126, 15);
            LHistorial.TabIndex = 4;
            LHistorial.Text = "Historial de Cotización";
            // 
            // GBPrenda
            // 
            GBPrenda.Controls.Add(panel3);
            GBPrenda.Controls.Add(panel2);
            GBPrenda.Controls.Add(panel1);
            GBPrenda.Controls.Add(RBPantalon);
            GBPrenda.Controls.Add(RBCamisa);
            GBPrenda.Location = new Point(20, 78);
            GBPrenda.Name = "GBPrenda";
            GBPrenda.Size = new Size(323, 156);
            GBPrenda.TabIndex = 5;
            GBPrenda.TabStop = false;
            GBPrenda.Text = "Prenda";
            // 
            // panel3
            // 
            panel3.Controls.Add(RBChupin);
            panel3.Controls.Add(RBComun);
            panel3.Location = new Point(85, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(109, 53);
            panel3.TabIndex = 7;
            // 
            // RBChupin
            // 
            RBChupin.AutoSize = true;
            RBChupin.Enabled = false;
            RBChupin.Location = new Point(0, 28);
            RBChupin.Name = "RBChupin";
            RBChupin.Size = new Size(64, 19);
            RBChupin.TabIndex = 3;
            RBChupin.Text = "Chupin";
            RBChupin.UseVisualStyleBackColor = true;
            // 
            // RBComun
            // 
            RBComun.AutoSize = true;
            RBComun.Checked = true;
            RBComun.Enabled = false;
            RBComun.Location = new Point(0, 0);
            RBComun.Name = "RBComun";
            RBComun.Size = new Size(65, 19);
            RBComun.TabIndex = 2;
            RBComun.TabStop = true;
            RBComun.Text = "Común";
            RBComun.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(RBCuelloMao);
            panel2.Controls.Add(RBCuelloComun);
            panel2.Location = new Point(208, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(109, 53);
            panel2.TabIndex = 7;
            // 
            // RBCuelloMao
            // 
            RBCuelloMao.AutoSize = true;
            RBCuelloMao.Location = new Point(0, 28);
            RBCuelloMao.Name = "RBCuelloMao";
            RBCuelloMao.Size = new Size(86, 19);
            RBCuelloMao.TabIndex = 3;
            RBCuelloMao.Text = "Cuello Mao";
            RBCuelloMao.UseVisualStyleBackColor = true;
            // 
            // RBCuelloComun
            // 
            RBCuelloComun.AutoSize = true;
            RBCuelloComun.Checked = true;
            RBCuelloComun.Location = new Point(0, 0);
            RBCuelloComun.Name = "RBCuelloComun";
            RBCuelloComun.Size = new Size(102, 19);
            RBCuelloComun.TabIndex = 2;
            RBCuelloComun.TabStop = true;
            RBCuelloComun.Text = "Cuello Común";
            RBCuelloComun.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(RBMangaLarga);
            panel1.Controls.Add(RBMangaCorta);
            panel1.Location = new Point(85, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 53);
            panel1.TabIndex = 6;
            // 
            // RBMangaLarga
            // 
            RBMangaLarga.AutoSize = true;
            RBMangaLarga.Location = new Point(0, 28);
            RBMangaLarga.Name = "RBMangaLarga";
            RBMangaLarga.Size = new Size(94, 19);
            RBMangaLarga.TabIndex = 3;
            RBMangaLarga.Text = "Manga Larga";
            RBMangaLarga.UseVisualStyleBackColor = true;
            // 
            // RBMangaCorta
            // 
            RBMangaCorta.AutoSize = true;
            RBMangaCorta.Checked = true;
            RBMangaCorta.Location = new Point(0, 0);
            RBMangaCorta.Name = "RBMangaCorta";
            RBMangaCorta.Size = new Size(94, 19);
            RBMangaCorta.TabIndex = 2;
            RBMangaCorta.TabStop = true;
            RBMangaCorta.Text = "Manga Corta";
            RBMangaCorta.UseVisualStyleBackColor = true;
            // 
            // RBPantalon
            // 
            RBPantalon.AutoSize = true;
            RBPantalon.Location = new Point(0, 91);
            RBPantalon.Name = "RBPantalon";
            RBPantalon.Size = new Size(72, 19);
            RBPantalon.TabIndex = 1;
            RBPantalon.Text = "Pantalón";
            RBPantalon.UseVisualStyleBackColor = true;
            RBPantalon.CheckedChanged += RBPantalon_CheckedChanged;
            // 
            // RBCamisa
            // 
            RBCamisa.AutoSize = true;
            RBCamisa.Checked = true;
            RBCamisa.Location = new Point(3, 22);
            RBCamisa.Name = "RBCamisa";
            RBCamisa.Size = new Size(64, 19);
            RBCamisa.TabIndex = 0;
            RBCamisa.TabStop = true;
            RBCamisa.Text = "Camisa";
            RBCamisa.UseVisualStyleBackColor = true;
            RBCamisa.CheckedChanged += RBCamisa_CheckedChanged;
            // 
            // GBCalidad
            // 
            GBCalidad.Controls.Add(RBPremium);
            GBCalidad.Controls.Add(RBStandard);
            GBCalidad.Location = new Point(23, 284);
            GBCalidad.Name = "GBCalidad";
            GBCalidad.Size = new Size(320, 52);
            GBCalidad.TabIndex = 6;
            GBCalidad.TabStop = false;
            GBCalidad.Text = "Calidad";
            // 
            // RBPremium
            // 
            RBPremium.AutoSize = true;
            RBPremium.Location = new Point(104, 22);
            RBPremium.Name = "RBPremium";
            RBPremium.Size = new Size(74, 19);
            RBPremium.TabIndex = 9;
            RBPremium.Text = "Premium";
            RBPremium.UseVisualStyleBackColor = true;
            // 
            // RBStandard
            // 
            RBStandard.AutoSize = true;
            RBStandard.Checked = true;
            RBStandard.Location = new Point(6, 22);
            RBStandard.Name = "RBStandard";
            RBStandard.Size = new Size(72, 19);
            RBStandard.TabIndex = 8;
            RBStandard.TabStop = true;
            RBStandard.Text = "Standard";
            RBStandard.UseVisualStyleBackColor = true;
            // 
            // BDisponibilidad
            // 
            BDisponibilidad.Location = new Point(20, 246);
            BDisponibilidad.Name = "BDisponibilidad";
            BDisponibilidad.Size = new Size(106, 23);
            BDisponibilidad.TabIndex = 7;
            BDisponibilidad.Text = "Consulta Stock";
            BDisponibilidad.UseVisualStyleBackColor = true;
            BDisponibilidad.Click += BDisponibilidad_Click;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(132, 250);
            LStock.Name = "LStock";
            LStock.Size = new Size(173, 15);
            LStock.TabIndex = 8;
            LStock.Text = "Unidaded de Stock Disponibles:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TBCantidad);
            groupBox1.Controls.Add(LCantidad);
            groupBox1.Controls.Add(TBPrecio);
            groupBox1.Controls.Add(LPesos);
            groupBox1.Location = new Point(23, 342);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 52);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Precio Unitario y Cantidad";
            // 
            // TBCantidad
            // 
            TBCantidad.Location = new Point(157, 21);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(66, 23);
            TBCantidad.TabIndex = 14;
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Location = new Point(96, 26);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(55, 15);
            LCantidad.TabIndex = 13;
            LCantidad.Text = "Cantidad";
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(22, 21);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(66, 23);
            TBPrecio.TabIndex = 12;
            // 
            // LPesos
            // 
            LPesos.AutoSize = true;
            LPesos.Location = new Point(6, 25);
            LPesos.Name = "LPesos";
            LPesos.Size = new Size(13, 15);
            LPesos.TabIndex = 11;
            LPesos.Text = "$";
            // 
            // BCotizar
            // 
            BCotizar.Location = new Point(20, 407);
            BCotizar.Name = "BCotizar";
            BCotizar.Size = new Size(106, 23);
            BCotizar.TabIndex = 11;
            BCotizar.Text = "Cotizar";
            BCotizar.UseVisualStyleBackColor = true;
            BCotizar.Click += BCotizar_Click;
            // 
            // LPrecioFinal
            // 
            LPrecioFinal.AutoSize = true;
            LPrecioFinal.Location = new Point(132, 411);
            LPrecioFinal.Name = "LPrecioFinal";
            LPrecioFinal.Size = new Size(13, 15);
            LPrecioFinal.TabIndex = 12;
            LPrecioFinal.Text = "$";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 441);
            Controls.Add(LPrecioFinal);
            Controls.Add(BCotizar);
            Controls.Add(groupBox1);
            Controls.Add(LStock);
            Controls.Add(BDisponibilidad);
            Controls.Add(GBCalidad);
            Controls.Add(GBPrenda);
            Controls.Add(LHistorial);
            Controls.Add(LCodigoVendedor);
            Controls.Add(LNombreVendedor);
            Controls.Add(LDireccionTienda);
            Controls.Add(LNombreTienda);
            Name = "Form1";
            Text = "Cotizador Tienda de Ropa";
            Load += Form1_Load;
            GBPrenda.ResumeLayout(false);
            GBPrenda.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            GBCalidad.ResumeLayout(false);
            GBCalidad.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombreTienda;
        private Label LDireccionTienda;
        private Label LNombreVendedor;
        private Label LCodigoVendedor;
        private Label LHistorial;
        private GroupBox GBPrenda;
        private Panel panel3;
        private RadioButton RBChupin;
        private RadioButton RBComun;
        private Panel panel2;
        private RadioButton RBCuelloMao;
        private RadioButton RBCuelloComun;
        private Panel panel1;
        private RadioButton RBMangaLarga;
        private RadioButton RBMangaCorta;
        private RadioButton RBPantalon;
        private RadioButton RBCamisa;
        private GroupBox GBCalidad;
        private Button BDisponibilidad;
        private Label LStock;
        private RadioButton RBPremium;
        private RadioButton RBStandard;
        private GroupBox groupBox1;
        private TextBox TBCantidad;
        private Label LCantidad;
        private TextBox TBPrecio;
        private Label LPesos;
        private Button BCotizar;
        private Label LPrecioFinal;
        private System.Windows.Forms.Timer timer;
    }
}