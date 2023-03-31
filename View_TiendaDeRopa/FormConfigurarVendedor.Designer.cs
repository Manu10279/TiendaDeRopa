namespace View_TiendaDeRopa
{
    partial class FormConfigurarVendedor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurarVendedor));
            LVendedorNombre = new Label();
            TBVendedorNombre = new TextBox();
            TBVendedorApellido = new TextBox();
            LVendedorApellido = new Label();
            LVendedorCodigo = new Label();
            BGuardar = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LVendedorNombre
            // 
            LVendedorNombre.AutoSize = true;
            LVendedorNombre.Location = new Point(12, 14);
            LVendedorNombre.Name = "LVendedorNombre";
            LVendedorNombre.Size = new Size(57, 15);
            LVendedorNombre.TabIndex = 0;
            LVendedorNombre.Text = "Nombre: ";
            // 
            // TBVendedorNombre
            // 
            TBVendedorNombre.Location = new Point(74, 11);
            TBVendedorNombre.MaxLength = 17;
            TBVendedorNombre.Name = "TBVendedorNombre";
            TBVendedorNombre.Size = new Size(198, 23);
            TBVendedorNombre.TabIndex = 1;
            // 
            // TBVendedorApellido
            // 
            TBVendedorApellido.Location = new Point(74, 40);
            TBVendedorApellido.MaxLength = 17;
            TBVendedorApellido.Name = "TBVendedorApellido";
            TBVendedorApellido.Size = new Size(198, 23);
            TBVendedorApellido.TabIndex = 3;
            // 
            // LVendedorApellido
            // 
            LVendedorApellido.AutoSize = true;
            LVendedorApellido.Location = new Point(12, 43);
            LVendedorApellido.Name = "LVendedorApellido";
            LVendedorApellido.Size = new Size(57, 15);
            LVendedorApellido.TabIndex = 2;
            LVendedorApellido.Text = "Apellido: ";
            // 
            // LVendedorCodigo
            // 
            LVendedorCodigo.AutoSize = true;
            LVendedorCodigo.Location = new Point(12, 72);
            LVendedorCodigo.Name = "LVendedorCodigo";
            LVendedorCodigo.Size = new Size(49, 15);
            LVendedorCodigo.TabIndex = 4;
            LVendedorCodigo.Text = "Código:";
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(12, 96);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(260, 23);
            BGuardar.TabIndex = 5;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // FormConfigurarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 131);
            Controls.Add(BGuardar);
            Controls.Add(LVendedorCodigo);
            Controls.Add(TBVendedorApellido);
            Controls.Add(LVendedorApellido);
            Controls.Add(TBVendedorNombre);
            Controls.Add(LVendedorNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormConfigurarVendedor";
            Text = "Configurar Vendedor";
            Load += FormConfigurarVendedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LVendedorNombre;
        private TextBox TBVendedorNombre;
        private TextBox TBVendedorApellido;
        private Label LVendedorApellido;
        private Label LVendedorCodigo;
        private Button BGuardar;
        private System.Windows.Forms.Timer timer;
    }
}