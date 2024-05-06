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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvListaSocios
            // 
            dgvListaSocios.AllowUserToAddRows = false;
            dgvListaSocios.BackgroundColor = SystemColors.ButtonFace;
            dgvListaSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaSocios.Location = new Point(70, 183);
            dgvListaSocios.Margin = new Padding(3, 4, 3, 4);
            dgvListaSocios.Name = "dgvListaSocios";
            dgvListaSocios.RowHeadersWidth = 51;
            dgvListaSocios.RowTemplate.Height = 25;
            dgvListaSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaSocios.Size = new Size(982, 437);
            dgvListaSocios.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(58, 152, 146);
            btnBuscar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(873, 125);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 49);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(131, 52);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(342, 32);
            txtNombre.TabIndex = 31;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(6, 18, 30);
            label1.Location = new Point(29, 64);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 30;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(6, 18, 30);
            label2.Location = new Point(523, 64);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 34;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(673, 52);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(342, 32);
            txtApellido.TabIndex = 33;
            // 
            // FormListaSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1119, 643);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(dgvListaSocios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListaSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Socios";
            ((System.ComponentModel.ISupportInitialize)dgvListaSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaSocios;
        private Button btnBuscar;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
    }
}