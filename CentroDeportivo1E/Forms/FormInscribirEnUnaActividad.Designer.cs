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
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(58, 152, 146);
            btnInscribir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.Location = new Point(320, 303);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(134, 49);
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
            btnCancelar.Location = new Point(48, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(48, 93);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(85, 25);
            lblSocio.TabIndex = 2;
            lblSocio.Text = "SOCIO";
            lblSocio.Click += lblSocio_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoEllipsis = true;
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(48, 197);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(117, 25);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "Actividad";
            // 
            // cmbActividades
            // 
            cmbActividades.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbActividades.FormattingEnabled = true;
            cmbActividades.Location = new Point(48, 225);
            cmbActividades.Margin = new Padding(3, 4, 3, 4);
            cmbActividades.Name = "cmbActividades";
            cmbActividades.Size = new Size(405, 33);
            cmbActividades.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvActividades);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(531, 61);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(368, 315);
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
            dgvActividades.Location = new Point(32, 52);
            dgvActividades.Margin = new Padding(3, 4, 3, 4);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.Size = new Size(299, 217);
            dgvActividades.TabIndex = 6;
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(48, 121);
            cmbSocio.Margin = new Padding(3, 4, 3, 4);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(405, 33);
            cmbSocio.TabIndex = 10;
            cmbSocio.SelectedIndexChanged += cmbSocio_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(285, 386);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormInscribirEnUnaActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(928, 451);
            Controls.Add(radioButton1);
            Controls.Add(cmbSocio);
            Controls.Add(groupBox1);
            Controls.Add(cmbActividades);
            Controls.Add(lblActividad);
            Controls.Add(lblSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnInscribir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInscribirEnUnaActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInscribirEnUnaActividad";
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
        private RadioButton radioButton1;
    }
}