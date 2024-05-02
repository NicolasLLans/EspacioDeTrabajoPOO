namespace CentroDeportivo1E.Forms
{
    partial class FormAltaActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaActividades));
            label1 = new Label();
            label2 = new Label();
            descripcionActividad = new TextBox();
            textBoxPrecio = new TextBox();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 83);
            label1.Name = "label1";
            label1.Size = new Size(395, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Nombre de la Actividad";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 206);
            label2.Name = "label2";
            label2.Size = new Size(365, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el Valor de la Actividad";
            label2.Click += label2_Click;
            // 
            // descripcionActividad
            // 
            descripcionActividad.Location = new Point(515, 83);
            descripcionActividad.Multiline = true;
            descripcionActividad.Name = "descripcionActividad";
            descripcionActividad.Size = new Size(386, 35);
            descripcionActividad.TabIndex = 2;
            descripcionActividad.TextChanged += descripcionActividad_TextChanged;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(515, 208);
            textBoxPrecio.Multiline = true;
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(183, 34);
            textBoxPrecio.TabIndex = 3;
            textBoxPrecio.TextChanged += textBox1_TextChanged_1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(168, 105, 53);
            buttonCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(170, 331);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(143, 49);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.FromArgb(58, 152, 146);
            buttonAceptar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAceptar.ForeColor = Color.White;
            buttonAceptar.Location = new Point(629, 331);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(143, 49);
            buttonAceptar.TabIndex = 5;
            buttonAceptar.Text = "ACEPTAR";
            buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // FormAltaActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(982, 450);
            Controls.Add(buttonAceptar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxPrecio);
            Controls.Add(descripcionActividad);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAltaActividades";
            Text = "ALTA DE ACTIVIDADES";
            Load += FormAltaActividades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox descripcionActividad;
        private TextBox textBoxPrecio;
        private Button buttonCancelar;
        private Button buttonAceptar;
    }
}