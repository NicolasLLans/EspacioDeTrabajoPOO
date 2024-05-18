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
            txtNumeroSocio = new TextBox();
            lblActividad = new Label();
            txtActividad = new ComboBox();
            groupBox1 = new GroupBox();
            dgvActividades = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(58, 152, 146);
            btnInscribir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.Location = new Point(188, 227);
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
            btnCancelar.Size = new Size(121, 37);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(42, 70);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(91, 18);
            lblSocio.TabIndex = 2;
            lblSocio.Text = "Nro Socio";
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(42, 90);
            txtNumeroSocio.Margin = new Padding(3, 2, 3, 2);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(263, 23);
            txtNumeroSocio.TabIndex = 3;
            txtNumeroSocio.TabStop = false;
            // 
            // lblActividad
            // 
            lblActividad.AutoEllipsis = true;
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(42, 148);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(87, 18);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "Actividad";
            // 
            // txtActividad
            // 
            txtActividad.FormattingEnabled = true;
            txtActividad.Location = new Point(42, 169);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(263, 23);
            txtActividad.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvActividades);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(347, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 236);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACTIVIDADES";
            // 
            // dgvActividades
            // 
            dgvActividades.BackgroundColor = SystemColors.ButtonHighlight;
            dgvActividades.BorderStyle = BorderStyle.Fixed3D;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.GridColor = SystemColors.InactiveBorder;
            dgvActividades.Location = new Point(28, 39);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.Size = new Size(262, 163);
            dgvActividades.TabIndex = 6;
            // 
            // FormInscribirEnUnaActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox1);
            Controls.Add(txtActividad);
            Controls.Add(lblActividad);
            Controls.Add(txtNumeroSocio);
            Controls.Add(lblSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnInscribir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInscribirEnUnaActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInscribirEnUnaActividad";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribir;
        private Button btnCancelar;
        private Label lblSocio;
        private TextBox txtNumeroSocio;
        private Label lblActividad;
        private ComboBox txtActividad;
        private GroupBox groupBox1;
        private DataGridView dgvActividades;
    }
}