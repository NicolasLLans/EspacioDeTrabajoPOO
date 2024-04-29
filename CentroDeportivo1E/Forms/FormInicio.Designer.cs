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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            msOpciones = new MenuStrip();
            dFGDFToolStripMenuItem = new ToolStripMenuItem();
            sOCIOSToolStripMenuItem = new ToolStripMenuItem();
            nOSOCIOSToolStripMenuItem = new ToolStripMenuItem();
            pERSONALToolStripMenuItem = new ToolStripMenuItem();
            pAGOCUOTASToolStripMenuItem = new ToolStripMenuItem();
            cUOTASToolStripMenuItem = new ToolStripMenuItem();
            aCTIVIDADESToolStripMenuItem = new ToolStripMenuItem();
            lISTARCUOTASToolStripMenuItem = new ToolStripMenuItem();
            vENCIMIENTOSToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBienvenida = new TextBox();
            msOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msOpciones
            // 
            msOpciones.BackColor = Color.FromArgb(205, 210, 188);
            msOpciones.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            msOpciones.ImageScalingSize = new Size(50, 50);
            msOpciones.Items.AddRange(new ToolStripItem[] { dFGDFToolStripMenuItem, pAGOCUOTASToolStripMenuItem, lISTARCUOTASToolStripMenuItem, vENCIMIENTOSToolStripMenuItem });
            msOpciones.Location = new Point(0, 0);
            msOpciones.Name = "msOpciones";
            msOpciones.RenderMode = ToolStripRenderMode.System;
            msOpciones.Size = new Size(1422, 58);
            msOpciones.TabIndex = 0;
            msOpciones.Text = "menuStrip1";
            // 
            // dFGDFToolStripMenuItem
            // 
            dFGDFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sOCIOSToolStripMenuItem, nOSOCIOSToolStripMenuItem, pERSONALToolStripMenuItem });
            dFGDFToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            dFGDFToolStripMenuItem.Image = Properties.Resources.IconoAgregar;
            dFGDFToolStripMenuItem.Name = "dFGDFToolStripMenuItem";
            dFGDFToolStripMenuItem.Size = new Size(130, 54);
            dFGDFToolStripMenuItem.Text = "ALTA";
            // 
            // sOCIOSToolStripMenuItem
            // 
            sOCIOSToolStripMenuItem.Name = "sOCIOSToolStripMenuItem";
            sOCIOSToolStripMenuItem.Size = new Size(215, 36);
            sOCIOSToolStripMenuItem.Text = "SOCIOS";
            sOCIOSToolStripMenuItem.Click += sOCIOSToolStripMenuItem_Click;
            // 
            // nOSOCIOSToolStripMenuItem
            // 
            nOSOCIOSToolStripMenuItem.Name = "nOSOCIOSToolStripMenuItem";
            nOSOCIOSToolStripMenuItem.Size = new Size(215, 36);
            nOSOCIOSToolStripMenuItem.Text = "NO SOCIOS";
            // 
            // pERSONALToolStripMenuItem
            // 
            pERSONALToolStripMenuItem.Name = "pERSONALToolStripMenuItem";
            pERSONALToolStripMenuItem.Size = new Size(215, 36);
            pERSONALToolStripMenuItem.Text = "EMPLEADO";
            pERSONALToolStripMenuItem.Click += pERSONALToolStripMenuItem_Click;
            // 
            // pAGOCUOTASToolStripMenuItem
            // 
            pAGOCUOTASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cUOTASToolStripMenuItem, aCTIVIDADESToolStripMenuItem });
            pAGOCUOTASToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            pAGOCUOTASToolStripMenuItem.Image = Properties.Resources.iconoDinero;
            pAGOCUOTASToolStripMenuItem.Name = "pAGOCUOTASToolStripMenuItem";
            pAGOCUOTASToolStripMenuItem.Size = new Size(139, 54);
            pAGOCUOTASToolStripMenuItem.Text = "PAGO";
            // 
            // cUOTASToolStripMenuItem
            // 
            cUOTASToolStripMenuItem.Name = "cUOTASToolStripMenuItem";
            cUOTASToolStripMenuItem.Size = new Size(236, 36);
            cUOTASToolStripMenuItem.Text = "CUOTAS";
            // 
            // aCTIVIDADESToolStripMenuItem
            // 
            aCTIVIDADESToolStripMenuItem.Name = "aCTIVIDADESToolStripMenuItem";
            aCTIVIDADESToolStripMenuItem.Size = new Size(236, 36);
            aCTIVIDADESToolStripMenuItem.Text = "ACTIVIDADES";
            // 
            // lISTARCUOTASToolStripMenuItem
            // 
            lISTARCUOTASToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            lISTARCUOTASToolStripMenuItem.Image = Properties.Resources.iconoListar;
            lISTARCUOTASToolStripMenuItem.Name = "lISTARCUOTASToolStripMenuItem";
            lISTARCUOTASToolStripMenuItem.Size = new Size(246, 54);
            lISTARCUOTASToolStripMenuItem.Text = "LISTAR CUOTAS";
            // 
            // vENCIMIENTOSToolStripMenuItem
            // 
            vENCIMIENTOSToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            vENCIMIENTOSToolStripMenuItem.Image = Properties.Resources.iconoVencimiento;
            vENCIMIENTOSToolStripMenuItem.Name = "vENCIMIENTOSToolStripMenuItem";
            vENCIMIENTOSToolStripMenuItem.Size = new Size(245, 54);
            vENCIMIENTOSToolStripMenuItem.Text = "VENCIMIENTOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoClub;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(885, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 411);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 154);
            label1.Name = "label1";
            label1.Size = new Size(250, 48);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // txtBienvenida
            // 
            txtBienvenida.BackColor = Color.FromArgb(6, 18, 30);
            txtBienvenida.BorderStyle = BorderStyle.None;
            txtBienvenida.Enabled = false;
            txtBienvenida.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBienvenida.ForeColor = Color.White;
            txtBienvenida.Location = new Point(323, 219);
            txtBienvenida.Multiline = true;
            txtBienvenida.Name = "txtBienvenida";
            txtBienvenida.ReadOnly = true;
            txtBienvenida.Size = new Size(455, 243);
            txtBienvenida.TabIndex = 3;
            txtBienvenida.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 18, 30);
            ClientSize = new Size(1422, 656);
            Controls.Add(txtBienvenida);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(msOpciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += FormInicio_Load;
            msOpciones.ResumeLayout(false);
            msOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msOpciones;
        private ToolStripMenuItem dFGDFToolStripMenuItem;
        private ToolStripMenuItem pAGOCUOTASToolStripMenuItem;
        private ToolStripMenuItem lISTARCUOTASToolStripMenuItem;
        private ToolStripMenuItem vENCIMIENTOSToolStripMenuItem;
        private ToolStripMenuItem sOCIOSToolStripMenuItem;
        private ToolStripMenuItem nOSOCIOSToolStripMenuItem;
        private ToolStripMenuItem cUOTASToolStripMenuItem;
        private ToolStripMenuItem aCTIVIDADESToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBienvenida;
        private ToolStripMenuItem pERSONALToolStripMenuItem;
    }
}