namespace CentroDeportivo1E.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoClub;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(32, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 223);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 57);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(284, 154);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(294, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 33);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasena.Location = new Point(294, 197);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(300, 33);
            txtContrasena.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(58, 152, 146);
            btnIngresar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(366, 278);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(156, 47);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(144, 278);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(156, 47);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 18, 30);
            ClientSize = new Size(628, 346);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}