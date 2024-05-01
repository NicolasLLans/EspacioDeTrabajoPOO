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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(515, 208);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 34);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(168, 105, 53);
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(170, 331);
            button1.Name = "button1";
            button1.Size = new Size(143, 49);
            button1.TabIndex = 4;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(58, 152, 146);
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(629, 331);
            button2.Name = "button2";
            button2.Size = new Size(143, 49);
            button2.TabIndex = 5;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormAltaActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(982, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}