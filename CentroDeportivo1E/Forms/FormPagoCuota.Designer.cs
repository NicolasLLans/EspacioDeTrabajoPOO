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
            cmbSocio = new ComboBox();
            groupBox1 = new GroupBox();
            dgvHistorialPagos = new DataGridView();
            lblSocio = new Label();
            btnCancelar = new Button();
            btnInscribir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPagos).BeginInit();
            SuspendLayout();
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(25, 101);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(355, 26);
            cmbSocio.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHistorialPagos);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(444, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 236);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "HISTORIAL PAGOS";
            // 
            // dgvHistorialPagos
            // 
            dgvHistorialPagos.AllowUserToAddRows = false;
            dgvHistorialPagos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHistorialPagos.BorderStyle = BorderStyle.Fixed3D;
            dgvHistorialPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialPagos.GridColor = SystemColors.InactiveBorder;
            dgvHistorialPagos.Location = new Point(21, 43);
            dgvHistorialPagos.Name = "dgvHistorialPagos";
            dgvHistorialPagos.RowTemplate.Height = 25;
            dgvHistorialPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialPagos.Size = new Size(355, 163);
            dgvHistorialPagos.TabIndex = 6;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(25, 80);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(67, 18);
            lblSocio.TabIndex = 11;
            lblSocio.Text = "SOCIO";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(40, 180);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 37);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(58, 152, 146);
            btnInscribir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.Location = new Point(231, 180);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(149, 37);
            btnInscribir.TabIndex = 14;
            btnInscribir.Text = "PAGAR CUOTA";
            btnInscribir.UseVisualStyleBackColor = false;
            // 
            // FormPagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 299);
            Controls.Add(btnCancelar);
            Controls.Add(btnInscribir);
            Controls.Add(cmbSocio);
            Controls.Add(groupBox1);
            Controls.Add(lblSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPagoCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGO CUOTA";
            Load += FormPagoCuota_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSocio;
        private GroupBox groupBox1;
        private DataGridView dgvHistorialPagos;
        private Label lblSocio;
        private Button btnCancelar;
        private Button btnInscribir;
    }
}