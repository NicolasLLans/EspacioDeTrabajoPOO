namespace CentroDeportivo1E.Forms
{
    partial class FormImpresiones
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
            cmbSocio = new ComboBox();
            lblSocio = new Label();
            btnImprimir = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(51, 68);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(355, 26);
            cmbSocio.TabIndex = 10;
            // 
            // lblSocio
            // 
            lblSocio.AutoEllipsis = true;
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(51, 47);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(67, 18);
            lblSocio.TabIndex = 11;
            lblSocio.Text = "SOCIO";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(58, 152, 146);
            btnImprimir.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(288, 201);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(117, 37);
            btnImprimir.TabIndex = 12;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 105, 53);
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(37, 200);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 37);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormImpresiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 338);
            Controls.Add(btnCancelar);
            Controls.Add(btnImprimir);
            Controls.Add(cmbSocio);
            Controls.Add(lblSocio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormImpresiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormImpresiones";
            Load += FormImpresiones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSocio;
        private Label lblSocio;
        private Button btnImprimir;
        private Button btnCancelar;
    }
}