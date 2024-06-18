namespace CentroDeportivo1E.Forms
{
    partial class FormPagoCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoCuota));
            dgvHistorialPagos = new DataGridView();
            btnCancelar = new Button();
            btnPagar = new Button();
            dgvListaClientes = new DataGridView();
            txtBusquedaClientes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPagos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorialPagos
            // 
            dgvHistorialPagos.AllowUserToAddRows = false;
            dgvHistorialPagos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHistorialPagos.BorderStyle = BorderStyle.Fixed3D;
            dgvHistorialPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialPagos.GridColor = SystemColors.InactiveBorder;
            dgvHistorialPagos.Location = new Point(700, 108);
            dgvHistorialPagos.Name = "dgvHistorialPagos";
            dgvHistorialPagos.RowTemplate.Height = 25;
            dgvHistorialPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialPagos.Size = new Size(506, 221);
            dgvHistorialPagos.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(163, 479);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "VOLVER";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(58, 152, 146);
            btnPagar.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(386, 479);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(149, 37);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.AllowUserToAddRows = false;
            dgvListaClientes.AllowUserToDeleteRows = false;
            dgvListaClientes.AllowUserToResizeColumns = false;
            dgvListaClientes.AllowUserToResizeRows = false;
            dgvListaClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvListaClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Location = new Point(48, 108);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.ReadOnly = true;
            dgvListaClientes.RowTemplate.Height = 25;
            dgvListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaClientes.Size = new Size(632, 221);
            dgvListaClientes.TabIndex = 7;
            dgvListaClientes.SelectionChanged += dgvListaClientes_SelectionChanged;
            // 
            // txtBusquedaClientes
            // 
            txtBusquedaClientes.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBusquedaClientes.Location = new Point(48, 57);
            txtBusquedaClientes.Name = "txtBusquedaClientes";
            txtBusquedaClientes.Size = new Size(632, 27);
            txtBusquedaClientes.TabIndex = 1;
            txtBusquedaClientes.TextChanged += txtBusquedaClientes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(247, 18);
            label1.TabIndex = 29;
            label1.Text = "BUSCAR SOCIO/NO SOCIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(6, 18, 30);
            label2.Location = new Point(369, 356);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
            label2.TabIndex = 30;
            label2.Text = "MONTO A PAGAR:";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMonto.Location = new Point(369, 389);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(262, 27);
            txtMonto.TabIndex = 31;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(6, 18, 30);
            label3.Location = new Point(700, 87);
            label3.Name = "label3";
            label3.Size = new Size(205, 18);
            label3.TabIndex = 32;
            label3.Text = "HISTORIAL DE PAGOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(6, 18, 30);
            label4.Location = new Point(48, 361);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 33;
            label4.Text = "DESDE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(6, 18, 30);
            label5.Location = new Point(48, 405);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 34;
            label5.Text = "HASTA:";
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(130, 356);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(154, 27);
            dtpDesde.TabIndex = 2;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // dtpHasta
            // 
            dtpHasta.Enabled = false;
            dtpHasta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(130, 399);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(154, 27);
            dtpHasta.TabIndex = 3;
            // 
            // FormPagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 539);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvHistorialPagos);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBusquedaClientes);
            Controls.Add(dgvListaClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPagoCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar pago";
            Load += FormPagoCuota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPagos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnPagar;
        private DataGridView dgvListaClientes;
        private TextBox txtBusquedaClientes;
        private Label label1;
        private Label label2;
        private TextBox txtMonto;
        private DataGridView dgvHistorialPagos;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
    }
}