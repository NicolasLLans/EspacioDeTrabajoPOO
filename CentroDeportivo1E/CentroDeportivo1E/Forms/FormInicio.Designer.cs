namespace CentroDeportivo1E.Forms
{
    partial class FormInicio
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
            txtBienvenido = new TextBox();
            SuspendLayout();
            // 
            // txtBienvenido
            // 
            txtBienvenido.CausesValidation = false;
            txtBienvenido.Enabled = false;
            txtBienvenido.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtBienvenido.Location = new Point(102, 12);
            txtBienvenido.Name = "txtBienvenido";
            txtBienvenido.ReadOnly = true;
            txtBienvenido.Size = new Size(858, 59);
            txtBienvenido.TabIndex = 0;
            txtBienvenido.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 613);
            Controls.Add(txtBienvenido);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBienvenido;
    }
}