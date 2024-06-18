namespace CentroDeportivo1E.Forms
{
    partial class FormVencimientoDiarioSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVencimientoDiarioSocios));
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            dgvListaVencimientos = new DataGridView();
            btnCancelar = new Button();
            btnAvisarVencimiento = new Button();
            btnBuscarCuotasVencidas = new Button();
            txtBusquedaClientes = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaVencimientos).BeginInit();
            SuspendLayout();
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(384, 30);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(154, 27);
            dtpHasta.TabIndex = 2;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(107, 30);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(154, 27);
            dtpDesde.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(6, 18, 30);
            label5.Location = new Point(302, 34);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 43;
            label5.Text = "HASTA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(6, 18, 30);
            label4.Location = new Point(25, 34);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 42;
            label4.Text = "DESDE:";
            // 
            // dgvListaVencimientos
            // 
            dgvListaVencimientos.AllowUserToAddRows = false;
            dgvListaVencimientos.AllowUserToDeleteRows = false;
            dgvListaVencimientos.AllowUserToResizeColumns = false;
            dgvListaVencimientos.AllowUserToResizeRows = false;
            dgvListaVencimientos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvListaVencimientos.BorderStyle = BorderStyle.Fixed3D;
            dgvListaVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaVencimientos.Location = new Point(23, 147);
            dgvListaVencimientos.Name = "dgvListaVencimientos";
            dgvListaVencimientos.ReadOnly = true;
            dgvListaVencimientos.RowTemplate.Height = 25;
            dgvListaVencimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaVencimientos.Size = new Size(1113, 278);
            dgvListaVencimientos.TabIndex = 39;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(191, 440);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(185, 60);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "VOLVER";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAvisarVencimiento
            // 
            btnAvisarVencimiento.BackColor = Color.FromArgb(58, 152, 146);
            btnAvisarVencimiento.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvisarVencimiento.ForeColor = Color.White;
            btnAvisarVencimiento.Image = Properties.Resources.icons8_whatsapp_40__1_;
            btnAvisarVencimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAvisarVencimiento.Location = new Point(715, 440);
            btnAvisarVencimiento.Margin = new Padding(3, 2, 3, 2);
            btnAvisarVencimiento.Name = "btnAvisarVencimiento";
            btnAvisarVencimiento.Padding = new Padding(10, 0, 0, 0);
            btnAvisarVencimiento.Size = new Size(261, 60);
            btnAvisarVencimiento.TabIndex = 5;
            btnAvisarVencimiento.Text = "ENVIAR VENCIMIENTO";
            btnAvisarVencimiento.TextAlign = ContentAlignment.MiddleRight;
            btnAvisarVencimiento.UseVisualStyleBackColor = false;
            btnAvisarVencimiento.Click += btnAvisarVencimiento_Click;
            // 
            // btnBuscarCuotasVencidas
            // 
            btnBuscarCuotasVencidas.BackColor = Color.FromArgb(58, 152, 146);
            btnBuscarCuotasVencidas.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCuotasVencidas.ForeColor = Color.White;
            btnBuscarCuotasVencidas.Location = new Point(586, 20);
            btnBuscarCuotasVencidas.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCuotasVencidas.Name = "btnBuscarCuotasVencidas";
            btnBuscarCuotasVencidas.Size = new Size(149, 37);
            btnBuscarCuotasVencidas.TabIndex = 3;
            btnBuscarCuotasVencidas.Text = "BUSCAR";
            btnBuscarCuotasVencidas.UseVisualStyleBackColor = false;
            btnBuscarCuotasVencidas.Click += btnBuscarCuotasVencidas_Click;
            // 
            // txtBusquedaClientes
            // 
            txtBusquedaClientes.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBusquedaClientes.Location = new Point(25, 102);
            txtBusquedaClientes.Name = "txtBusquedaClientes";
            txtBusquedaClientes.Size = new Size(632, 27);
            txtBusquedaClientes.TabIndex = 4;
            txtBusquedaClientes.TextChanged += txtBusquedaClientes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(25, 81);
            label1.Name = "label1";
            label1.Size = new Size(145, 18);
            label1.TabIndex = 41;
            label1.Text = "BUSCAR SOCIO";
            // 
            // FormVencimientoDiarioSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1182, 511);
            Controls.Add(btnBuscarCuotasVencidas);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBusquedaClientes);
            Controls.Add(dgvListaVencimientos);
            Controls.Add(btnCancelar);
            Controls.Add(btnAvisarVencimiento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVencimientoDiarioSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vencimientos";
            Load += FormVencimientoDiarioSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaVencimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label label5;
        private Label label4;
        private DataGridView dgvListaVencimientos;
        private Button btnCancelar;
        private Button btnAvisarVencimiento;
        private Button btnBuscarCuotasVencidas;
        private TextBox txtBusquedaClientes;
        private Label label1;
    }
}