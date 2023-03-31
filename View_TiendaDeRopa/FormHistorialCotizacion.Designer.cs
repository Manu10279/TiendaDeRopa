namespace View_TiendaDeRopa
{
    partial class FormHistorialCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialCotizacion));
            DGVCotizaciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Prenda = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGVCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // DGVCotizaciones
            // 
            DGVCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Prenda, Cantidad, Precio, Fecha });
            DGVCotizaciones.Location = new Point(-1, -1);
            DGVCotizaciones.Name = "DGVCotizaciones";
            DGVCotizaciones.RowTemplate.Height = 25;
            DGVCotizaciones.Size = new Size(709, 451);
            DGVCotizaciones.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 40;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código del Vendedor";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Resizable = DataGridViewTriState.False;
            Codigo.Width = 80;
            // 
            // Prenda
            // 
            Prenda.HeaderText = "Prenda";
            Prenda.Name = "Prenda";
            Prenda.ReadOnly = true;
            Prenda.Resizable = DataGridViewTriState.False;
            Prenda.Width = 250;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = DataGridViewTriState.False;
            Cantidad.Width = 70;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Resizable = DataGridViewTriState.False;
            Precio.Width = 105;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha y Hora";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Resizable = DataGridViewTriState.False;
            Fecha.Width = 120;
            // 
            // FormHistorialCotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(DGVCotizaciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormHistorialCotizacion";
            Text = "Historial de Cotizaciones";
            FormClosing += FormHistorialCotizacion_FormClosing;
            Load += FormHistorialCotizacion_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCotizaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVCotizaciones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Prenda;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Fecha;
    }
}