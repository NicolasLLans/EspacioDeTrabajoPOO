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
            label2 = new Label();
            txtBusquedaClientes = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaVencimientos).BeginInit();
            SuspendLayout();
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(642, 34);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(154, 27);
            dtpHasta.TabIndex = 45;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(365, 35);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(154, 27);
            dtpDesde.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(6, 18, 30);
            label5.Location = new Point(560, 40);
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
            label4.Location = new Point(283, 40);
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
            dgvListaVencimientos.Location = new Point(23, 194);
            dgvListaVencimientos.Name = "dgvListaVencimientos";
            dgvListaVencimientos.ReadOnly = true;
            dgvListaVencimientos.RowTemplate.Height = 25;
            dgvListaVencimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaVencimientos.Size = new Size(1113, 221);
            dgvListaVencimientos.TabIndex = 39;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(255, 440);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 60);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "CANCELAR";
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
            btnAvisarVencimiento.Location = new Point(796, 440);
            btnAvisarVencimiento.Margin = new Padding(3, 2, 3, 2);
            btnAvisarVencimiento.Name = "btnAvisarVencimiento";
            btnAvisarVencimiento.Size = new Size(177, 60);
            btnAvisarVencimiento.TabIndex = 37;
            btnAvisarVencimiento.Text = "AVISAR VENCIMIENTO";
            btnAvisarVencimiento.TextAlign = ContentAlignment.MiddleRight;
            btnAvisarVencimiento.UseVisualStyleBackColor = false;
            btnAvisarVencimiento.Click += btnAvisarVencimiento_Click;
            // 
            // btnBuscarCuotasVencidas
            // 
            btnBuscarCuotasVencidas.BackColor = Color.FromArgb(58, 152, 146);
            btnBuscarCuotasVencidas.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCuotasVencidas.ForeColor = Color.White;
            btnBuscarCuotasVencidas.Location = new Point(844, 25);
            btnBuscarCuotasVencidas.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCuotasVencidas.Name = "btnBuscarCuotasVencidas";
            btnBuscarCuotasVencidas.Size = new Size(149, 37);
            btnBuscarCuotasVencidas.TabIndex = 46;
            btnBuscarCuotasVencidas.Text = "BUSCAR";
            btnBuscarCuotasVencidas.UseVisualStyleBackColor = false;
            btnBuscarCuotasVencidas.Click += btnBuscarCuotasVencidas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(6, 18, 30);
            label2.Location = new Point(79, 40);
            label2.Name = "label2";
            label2.Size = new Size(154, 18);
            label2.TabIndex = 47;
            label2.Text = "VENCIMIENTOS:";
            // 
            // txtBusquedaClientes
            // 
            txtBusquedaClientes.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBusquedaClientes.Location = new Point(23, 144);
            txtBusquedaClientes.Name = "txtBusquedaClientes";
            txtBusquedaClientes.Size = new Size(632, 27);
            txtBusquedaClientes.TabIndex = 40;
            txtBusquedaClientes.TextChanged += txtBusquedaClientes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(23, 123);
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
            Controls.Add(label2);
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
            Text = "VENCIMIENTOS";
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
        private Label label2;
        private TextBox txtBusquedaClientes;
        private Label label1;
    }
}