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
            DGVCotizaciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Prenda = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGVCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // DGVCotizaciones
            // 
            DGVCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Cantidad, Codigo, Prenda, Precio });
            DGVCotizaciones.Location = new Point(0, 0);
            DGVCotizaciones.Name = "DGVCotizaciones";
            DGVCotizaciones.RowTemplate.Height = 25;
            DGVCotizaciones.Size = new Size(800, 451);
            DGVCotizaciones.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha y Hora";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código del Vendedor";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Prenda
            // 
            Prenda.HeaderText = "Prenda";
            Prenda.Name = "Prenda";
            Prenda.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // FormHistorialCotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGVCotizaciones);
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
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Prenda;
        private DataGridViewTextBoxColumn Precio;
    }
}