namespace CentroDeportivo1E.Forms
{
    partial class FormListaSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaSocios));
            dgvListaSocios = new DataGridView();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvListaSocios
            // 
            dgvListaSocios.BackgroundColor = SystemColors.ButtonFace;
            dgvListaSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaSocios.Location = new Point(45, 38);
            dgvListaSocios.Name = "dgvListaSocios";
            dgvListaSocios.RowTemplate.Height = 25;
            dgvListaSocios.Size = new Size(859, 319);
            dgvListaSocios.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(58, 152, 146);
            btnBuscar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(779, 374);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 37);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormListaSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(953, 446);
            Controls.Add(btnBuscar);
            Controls.Add(dgvListaSocios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListaSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Socios";
            ((System.ComponentModel.ISupportInitialize)dgvListaSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaSocios;
        private Button btnBuscar;
    }
}