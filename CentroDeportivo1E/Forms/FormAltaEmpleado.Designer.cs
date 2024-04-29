namespace CentroDeportivo1E.Forms
{
    partial class FormAltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaEmpleado));
            btnCancelarAlta = new Button();
            btnIngresar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            label5 = new Label();
            txtContrasena = new TextBox();
            label6 = new Label();
            cmbPuesto = new ComboBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // btnCancelarAlta
            // 
            btnCancelarAlta.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelarAlta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarAlta.ForeColor = Color.White;
            btnCancelarAlta.Location = new Point(57, 454);
            btnCancelarAlta.Name = "btnCancelarAlta";
            btnCancelarAlta.Size = new Size(125, 37);
            btnCancelarAlta.TabIndex = 8;
            btnCancelarAlta.Text = "CANCELAR";
            btnCancelarAlta.UseVisualStyleBackColor = false;
            btnCancelarAlta.Click += btnCancelarAlta_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(58, 152, 146);
            btnIngresar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(338, 454);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(125, 37);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "DAR ALTA";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(163, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(163, 68);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 27);
            txtApellido.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(163, 113);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 27);
            txtTelefono.TabIndex = 16;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(6, 18, 30);
            label2.Location = new Point(32, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 17;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(6, 18, 30);
            label3.Location = new Point(32, 122);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 18;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(6, 18, 30);
            label4.Location = new Point(35, 348);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 20;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(163, 339);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(6, 18, 30);
            label5.Location = new Point(35, 396);
            label5.Name = "label5";
            label5.Size = new Size(116, 18);
            label5.TabIndex = 22;
            label5.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasena.Location = new Point(163, 387);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(300, 27);
            txtContrasena.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(6, 18, 30);
            label6.Location = new Point(39, 280);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 24;
            label6.Text = "Puesto:";
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Items.AddRange(new object[] { "ADMINISTRADOR", "INSTRUCTOR", "NUTRICIONISTA", "SECRETARIA" });
            cmbPuesto.Location = new Point(163, 276);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(304, 26);
            cmbPuesto.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(6, 18, 30);
            label7.Location = new Point(39, 221);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 41;
            label7.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(163, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '*';
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(6, 18, 30);
            label8.Location = new Point(39, 170);
            label8.Name = "label8";
            label8.Size = new Size(88, 18);
            label8.TabIndex = 39;
            label8.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(163, 161);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 27);
            txtDireccion.TabIndex = 38;
            // 
            // FormAltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(504, 517);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtDireccion);
            Controls.Add(cmbPuesto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtContrasena);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelarAlta);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAltaEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALTA PERSONAL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarAlta;
        private Button btnIngresar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private Label label5;
        private TextBox txtContrasena;
        private Label label6;
        private ComboBox cmbPuesto;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtDireccion;
    }
}