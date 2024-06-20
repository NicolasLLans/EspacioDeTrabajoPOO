namespace CentroDeportivo1E.Forms
{
    partial class FormConexion
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
            textBoxServidor = new TextBox();
            textBoxPuerto = new TextBox();
            textBoxBaseDatos = new TextBox();
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // textBoxServidor
            // 
            textBoxServidor.Location = new Point(43, 50);
            textBoxServidor.Name = "textBoxServidor";
            textBoxServidor.Size = new Size(298, 23);
            textBoxServidor.TabIndex = 0;
            textBoxServidor.Text = "localhost";
            // 
            // textBoxPuerto
            // 
            textBoxPuerto.Location = new Point(43, 125);
            textBoxPuerto.Name = "textBoxPuerto";
            textBoxPuerto.Size = new Size(298, 23);
            textBoxPuerto.TabIndex = 1;
            textBoxPuerto.Text = "3306";
            // 
            // textBoxBaseDatos
            // 
            textBoxBaseDatos.Location = new Point(43, 193);
            textBoxBaseDatos.Name = "textBoxBaseDatos";
            textBoxBaseDatos.Size = new Size(298, 23);
            textBoxBaseDatos.TabIndex = 2;
            textBoxBaseDatos.Text = "centrodeportivo1e";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(43, 266);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(298, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(43, 339);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.Size = new Size(298, 23);
            textBoxContrasena.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 5;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 105);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 6;
            label2.Text = "Puerto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 173);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 7;
            label3.Text = "DataBase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 246);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 8;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 319);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 9;
            label5.Text = "Contraseña";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(132, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 42);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "CONECTAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // FormConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxBaseDatos);
            Controls.Add(textBoxPuerto);
            Controls.Add(textBoxServidor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexion Base de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxServidor;
        private TextBox textBoxPuerto;
        private TextBox textBoxBaseDatos;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardar;
    }
}