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
            btnAgregarActividad = new Button();
            SuspendLayout();
            // 
            // labelIngreseDescripcionActividad
            // 
            labelIngreseDescripcionActividad.AutoSize = true;
            labelIngreseDescripcionActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngreseDescripcionActividad.Location = new Point(47, 81);
            labelIngreseDescripcionActividad.Name = "labelIngreseDescripcionActividad";
            labelIngreseDescripcionActividad.Size = new Size(162, 18);
            labelIngreseDescripcionActividad.TabIndex = 0;
            labelIngreseDescripcionActividad.Text = "Nombre Actividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 148);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // txtDescripcionActividad
            // 
            txtDescripcionActividad.Location = new Point(47, 101);
            txtDescripcionActividad.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionActividad.Multiline = true;
            txtDescripcionActividad.Name = "txtDescripcionActividad";
            txtDescripcionActividad.Size = new Size(309, 27);
            txtDescripcionActividad.TabIndex = 2;
            // 
            // txtIngresoValor
            // 
            txtIngresoValor.Location = new Point(47, 168);
            txtIngresoValor.Margin = new Padding(3, 2, 3, 2);
            txtIngresoValor.Multiline = true;
            txtIngresoValor.Name = "txtIngresoValor";
            txtIngresoValor.Size = new Size(309, 26);
            txtIngresoValor.TabIndex = 3;
            txtIngresoValor.TextAlign = HorizontalAlignment.Right;
            txtIngresoValor.KeyPress += txtIngresoValor_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(77, 236);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 37);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarActividad
            // 
            btnAgregarActividad.BackColor = Color.FromArgb(58, 152, 146);
            btnAgregarActividad.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarActividad.ForeColor = Color.White;
            btnAgregarActividad.Location = new Point(217, 236);
            btnAgregarActividad.Margin = new Padding(3, 2, 3, 2);
            btnAgregarActividad.Name = "btnAgregarActividad";
            btnAgregarActividad.Size = new Size(125, 37);
            btnAgregarActividad.TabIndex = 5;
            btnAgregarActividad.Text = "AGREGAR";
            btnAgregarActividad.UseVisualStyleBackColor = false;
            btnAgregarActividad.Click += btnAgregarActividad_Click;
            // 
            // FormAltaActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(408, 338);
            Controls.Add(btnAgregarActividad);
            Controls.Add(btnCancelar);
            Controls.Add(txtIngresoValor);
            Controls.Add(txtDescripcionActividad);
            Controls.Add(label2);
            Controls.Add(labelIngreseDescripcionActividad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAltaActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALTA DE ACTIVIDADES";
            Load += FormAltaActividades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngreseDescripcionActividad;
        private Label label2;
        private TextBox txtDescripcionActividad;
        private TextBox txtIngresoValor;
        private Button btnCancelar;
        private Button btnAgregarActividad;
    }
}