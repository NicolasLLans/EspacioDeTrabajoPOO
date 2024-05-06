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
            labelIngreseDescripcionActividad = new Label();
            label2 = new Label();
            txtDescripcionActividad = new TextBox();
            txtIngresoValor = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // labelIngreseDescripcionActividad
            // 
            labelIngreseDescripcionActividad.AutoSize = true;
            labelIngreseDescripcionActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngreseDescripcionActividad.Location = new Point(69, 83);
            labelIngreseDescripcionActividad.Name = "labelIngreseDescripcionActividad";
            labelIngreseDescripcionActividad.Size = new Size(395, 25);
            labelIngreseDescripcionActividad.TabIndex = 0;
            labelIngreseDescripcionActividad.Text = "Ingrese el Nombre de la Actividad";
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
            // 
            // txtDescripcionActividad
            // 
            txtDescripcionActividad.Location = new Point(515, 83);
            txtDescripcionActividad.Multiline = true;
            txtDescripcionActividad.Name = "txtDescripcionActividad";
            txtDescripcionActividad.Size = new Size(386, 35);
            txtDescripcionActividad.TabIndex = 2;
            // 
            // txtIngresoValor
            // 
            txtIngresoValor.Location = new Point(515, 208);
            txtIngresoValor.Multiline = true;
            txtIngresoValor.Name = "txtIngresoValor";
            txtIngresoValor.Size = new Size(183, 34);
            txtIngresoValor.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(170, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 49);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(58, 152, 146);
            btnAceptar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(629, 331);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(143, 49);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormAltaActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(982, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtIngresoValor);
            Controls.Add(txtDescripcionActividad);
            Controls.Add(label2);
            Controls.Add(labelIngreseDescripcionActividad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAltaActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALTA DE ACTIVIDADES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngreseDescripcionActividad;
        private Label label2;
        private TextBox txtDescripcionActividad;
        private TextBox txtIngresoValor;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}