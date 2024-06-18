namespace CentroDeportivo1E.Forms
{
    partial class FormAltaNoSocio
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
            cmbAptoFisico = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            txtDNI = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnCancelarAlta = new Button();
            btnAltaSocio = new Button();
            SuspendLayout();
            // 
            // cmbAptoFisico
            // 
            cmbAptoFisico.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbAptoFisico.FormattingEnabled = true;
            cmbAptoFisico.Items.AddRange(new object[] { "SI", "NO" });
            cmbAptoFisico.Location = new Point(173, 261);
            cmbAptoFisico.Name = "cmbAptoFisico";
            cmbAptoFisico.Size = new Size(81, 26);
            cmbAptoFisico.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(6, 18, 30);
            label6.Location = new Point(42, 269);
            label6.Name = "label6";
            label6.Size = new Size(107, 18);
            label6.TabIndex = 64;
            label6.Text = "Apto Fisico:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(6, 18, 30);
            label9.Location = new Point(42, 120);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 63;
            label9.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDNI.Location = new Point(173, 111);
            txtDNI.MaxLength = 10;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(300, 27);
            txtDNI.TabIndex = 3;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(6, 18, 30);
            label5.Location = new Point(42, 222);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 61;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(173, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(826, 27);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(6, 18, 30);
            label4.Location = new Point(42, 170);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 59;
            label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(173, 161);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(825, 27);
            txtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(6, 18, 30);
            label3.Location = new Point(568, 111);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 57;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(6, 18, 30);
            label2.Location = new Point(568, 63);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 56;
            label2.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(699, 102);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 27);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(699, 54);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(173, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(42, 63);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 52;
            label1.Text = "Nombre:";
            // 
            // btnCancelarAlta
            // 
            btnCancelarAlta.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelarAlta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarAlta.ForeColor = Color.White;
            btnCancelarAlta.Location = new Point(296, 366);
            btnCancelarAlta.Name = "btnCancelarAlta";
            btnCancelarAlta.Size = new Size(125, 37);
            btnCancelarAlta.TabIndex = 9;
            btnCancelarAlta.Text = "CANCELAR";
            btnCancelarAlta.UseVisualStyleBackColor = false;
            btnCancelarAlta.Click += btnCancelarAlta_Click;
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.BackColor = Color.FromArgb(58, 152, 146);
            btnAltaSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaSocio.ForeColor = Color.White;
            btnAltaSocio.Location = new Point(681, 366);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(135, 37);
            btnAltaSocio.TabIndex = 8;
            btnAltaSocio.Text = "DAR ALTA";
            btnAltaSocio.UseVisualStyleBackColor = false;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // FormAltaNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1037, 427);
            Controls.Add(cmbAptoFisico);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(txtDNI);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelarAlta);
            Controls.Add(btnAltaSocio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAltaNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAptoFisico;
        private Label label6;
        private Label label9;
        private TextBox txtDNI;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtDireccion;
        private Label label3;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private Button btnCancelarAlta;
        private Button btnAltaSocio;
    }
}