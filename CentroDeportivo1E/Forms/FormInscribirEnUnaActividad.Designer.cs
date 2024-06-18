namespace CentroDeportivo1E.Forms
{
    partial class FormInscribirEnUnaActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscribirEnUnaActividad));
            btnInscribir = new Button();
            btnCancelar = new Button();
            lblSocio = new Label();
            lblActividad = new Label();
            cmbActividades = new ComboBox();
            groupBox1 = new GroupBox();
            dgvActividades = new DataGridView();
            cmbSocio = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(58, 152, 146);
            btnInscribir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.Location = new Point(280, 227);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(117, 37);
            btnInscribir.TabIndex = 0;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += buttonInscribir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(42, 227);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 37);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(42, 70);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(67, 18);
            lblSocio.TabIndex = 2;
            lblSocio.Text = "SOCIO";
            lblSocio.Click += lblSocio_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoEllipsis = true;
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(42, 148);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(110, 18);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "ACTIVIDAD";
            // 
            // cmbActividades
            // 
            cmbActividades.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbActividades.FormattingEnabled = true;
            cmbActividades.Location = new Point(42, 169);
            cmbActividades.Name = "cmbActividades";
            cmbActividades.Size = new Size(355, 26);
            cmbActividades.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvActividades);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(465, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 236);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACTIVIDADES SOCIO";
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.BackgroundColor = SystemColors.ButtonHighlight;
            dgvActividades.BorderStyle = BorderStyle.Fixed3D;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.GridColor = SystemColors.InactiveBorder;
            dgvActividades.Location = new Point(28, 39);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.Size = new Size(262, 163);
            dgvActividades.TabIndex = 6;
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(42, 91);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(355, 26);
            cmbSocio.TabIndex = 10;
            cmbSocio.SelectedIndexChanged += cmbSocio_SelectedIndexChanged;
            // 
            // FormInscribirEnUnaActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(812, 338);
            Controls.Add(cmbSocio);
            Controls.Add(groupBox1);
            Controls.Add(cmbActividades);
            Controls.Add(lblActividad);
            Controls.Add(lblSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnInscribir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInscribirEnUnaActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscribir actividad";
            Load += FormInscribirEnUnaActividad_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribir;
        private Button btnCancelar;
        private Label lblSocio;
        private Label lblActividad;
        private ComboBox cmbActividades;
        private GroupBox groupBox1;
        private DataGridView dgvActividades;
        private ComboBox cmbSocio;
    }
}