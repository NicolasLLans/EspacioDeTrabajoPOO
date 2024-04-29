namespace CentroDeportivo1E.Forms
{
    partial class FormAltaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaSocio));
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
            btnIngresar = new Button();
            label6 = new Label();
            txtCuota = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(6, 18, 30);
            label5.Location = new Point(54, 247);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 37;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(178, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(6, 18, 30);
            label4.Location = new Point(54, 196);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 35;
            label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(182, 187);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 27);
            txtDireccion.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(6, 18, 30);
            label3.Location = new Point(50, 143);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 33;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(6, 18, 30);
            label2.Location = new Point(50, 98);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 32;
            label2.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(181, 134);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 27);
            txtTelefono.TabIndex = 31;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(181, 89);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 27);
            txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(181, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 28;
            label1.Text = "Nombre:";
            // 
            // btnCancelarAlta
            // 
            btnCancelarAlta.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelarAlta.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarAlta.ForeColor = Color.White;
            btnCancelarAlta.Location = new Point(104, 386);
            btnCancelarAlta.Name = "btnCancelarAlta";
            btnCancelarAlta.Size = new Size(125, 37);
            btnCancelarAlta.TabIndex = 27;
            btnCancelarAlta.Text = "CANCELAR";
            btnCancelarAlta.UseVisualStyleBackColor = false;
            btnCancelarAlta.Click += btnCancelarAlta_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(58, 152, 146);
            btnIngresar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(353, 386);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(125, 37);
            btnIngresar.TabIndex = 26;
            btnIngresar.Text = "DAR ALTA";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(6, 18, 30);
            label6.Location = new Point(54, 305);
            label6.Name = "label6";
            label6.Size = new Size(117, 18);
            label6.TabIndex = 39;
            label6.Text = "Valor Cuota:";
            // 
            // txtCuota
            // 
            txtCuota.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCuota.Location = new Point(178, 296);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(300, 27);
            txtCuota.TabIndex = 38;
            // 
            // FormAltaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(552, 466);
            Controls.Add(label6);
            Controls.Add(txtCuota);
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
            Controls.Add(btnIngresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAltaSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAltaSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


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
        private Button btnIngresar;
        private Label label6;
        private TextBox txtCuota;
    }
}