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
            txtActividad = new TextBox();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(58, 152, 146);
            btnInscribir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.Location = new Point(441, 244);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(143, 37);
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
            btnCancelar.Location = new Point(148, 242);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 37);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(94, 32);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(255, 18);
            lblSocio.TabIndex = 2;
            lblSocio.Text = "Ingrese un número de Socio";
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(400, 27);
            txtNumeroSocio.Margin = new Padding(3, 2, 3, 2);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(234, 23);
            txtNumeroSocio.TabIndex = 3;
            txtNumeroSocio.TabStop = false;
            // 
            // lblActividad
            // 
            lblActividad.AutoEllipsis = true;
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(94, 104);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(294, 18);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "Escriba el nombre de la actividad";
            // 
            // txtActividad
            // 
            txtActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtActividad.Location = new Point(400, 101);
            txtActividad.Margin = new Padding(3, 2, 3, 2);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(234, 27);
            txtActividad.TabIndex = 5;
            // 
            // FormInscribirEnUnaActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(700, 338);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribir;
        private Button btnCancelar;
        private Label lblSocio;
        private TextBox txtNumeroSocio;
        private Label lblActividad;
        private TextBox txtActividad;
    }
}