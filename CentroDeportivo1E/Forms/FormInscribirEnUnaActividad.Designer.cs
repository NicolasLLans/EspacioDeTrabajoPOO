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
            btnInscribir.Location = new Point(504, 325);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(163, 49);
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
            btnCancelar.Location = new Point(169, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(107, 43);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(329, 25);
            lblSocio.TabIndex = 2;
            lblSocio.Text = "Ingrese un número de Socio";
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(516, 45);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(125, 27);
            txtNumeroSocio.TabIndex = 3;
            txtNumeroSocio.TabStop = false;
            // 
            // lblActividad
            // 
            lblActividad.AutoEllipsis = true;
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(107, 139);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(288, 25);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "Seleccione una actividad";
            // 
            // txtActividad
            // 
            txtActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtActividad.Location = new Point(507, 137);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(142, 32);
            txtActividad.TabIndex = 5;
            txtActividad.TextChanged += txtActividad_TextChanged;
            // 
            // FormInscribirEnUnaActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(txtActividad);
            Controls.Add(lblActividad);
            Controls.Add(txtNumeroSocio);
            Controls.Add(lblSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnInscribir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInscribirEnUnaActividad";
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