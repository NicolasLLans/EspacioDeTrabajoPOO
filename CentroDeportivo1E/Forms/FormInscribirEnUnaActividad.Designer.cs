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
            buttonInscribir = new Button();
            buttonCancelar = new Button();
            labelSeleccionSocio = new Label();
            textBoxNumeroSocio = new TextBox();
            labelSeleccionActividad = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // buttonInscribir
            // 
            buttonInscribir.BackColor = Color.FromArgb(58, 152, 146);
            buttonInscribir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInscribir.ForeColor = Color.White;
            buttonInscribir.Location = new Point(504, 325);
            buttonInscribir.Name = "buttonInscribir";
            buttonInscribir.Size = new Size(163, 49);
            buttonInscribir.TabIndex = 0;
            buttonInscribir.Text = "INSCRIBIR";
            buttonInscribir.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(168, 105, 53);
            buttonCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(169, 323);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(143, 49);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // labelSeleccionSocio
            // 
            labelSeleccionSocio.AutoEllipsis = true;
            labelSeleccionSocio.AutoSize = true;
            labelSeleccionSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeleccionSocio.Location = new Point(107, 43);
            labelSeleccionSocio.Name = "labelSeleccionSocio";
            labelSeleccionSocio.Size = new Size(329, 25);
            labelSeleccionSocio.TabIndex = 2;
            labelSeleccionSocio.Text = "Ingrese un número de Socio";
            // 
            // textBoxNumeroSocio
            // 
            textBoxNumeroSocio.Location = new Point(516, 45);
            textBoxNumeroSocio.Name = "textBoxNumeroSocio";
            textBoxNumeroSocio.Size = new Size(125, 27);
            textBoxNumeroSocio.TabIndex = 3;
            textBoxNumeroSocio.TabStop = false;
            textBoxNumeroSocio.TextChanged += textBox1_TextChanged;
            // 
            // labelSeleccionActividad
            // 
            labelSeleccionActividad.AutoEllipsis = true;
            labelSeleccionActividad.AutoSize = true;
            labelSeleccionActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeleccionActividad.Location = new Point(107, 139);
            labelSeleccionActividad.Name = "labelSeleccionActividad";
            labelSeleccionActividad.Size = new Size(288, 25);
            labelSeleccionActividad.TabIndex = 4;
            labelSeleccionActividad.Text = "Seleccione una actividad";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Yoya", "Pilates", "Musculacion", "Entrenamiento Funcional", "Spinning", "CrossFit" });
            comboBox1.Location = new Point(516, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // FormInscribirEnUnaActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(labelSeleccionActividad);
            Controls.Add(textBoxNumeroSocio);
            Controls.Add(labelSeleccionSocio);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonInscribir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInscribirEnUnaActividad";
            Text = "FormInscribirEnUnaActividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInscribir;
        private Button buttonCancelar;
        private Label labelSeleccionSocio;
        private TextBox textBoxNumeroSocio;
        private Label labelSeleccionActividad;
        private ComboBox comboBox1;
    }
}