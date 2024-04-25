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
            menuStrip1 = new MenuStrip();
            dFGDFToolStripMenuItem = new ToolStripMenuItem();
            sOCIOSToolStripMenuItem = new ToolStripMenuItem();
            nOSOCIOSToolStripMenuItem = new ToolStripMenuItem();
            pAGOCUOTASToolStripMenuItem = new ToolStripMenuItem();
            cUOTASToolStripMenuItem = new ToolStripMenuItem();
            aCTIVIDADESToolStripMenuItem = new ToolStripMenuItem();
            lISTARCUOTASToolStripMenuItem = new ToolStripMenuItem();
            vENCIMIENTOSToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBienvenida = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Linen;
            menuStrip1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(50, 50);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dFGDFToolStripMenuItem, pAGOCUOTASToolStripMenuItem, lISTARCUOTASToolStripMenuItem, vENCIMIENTOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(995, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dFGDFToolStripMenuItem
            // 
            dFGDFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sOCIOSToolStripMenuItem, nOSOCIOSToolStripMenuItem });
            dFGDFToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            dFGDFToolStripMenuItem.Image = Properties.Resources.IconoAgregar;
            dFGDFToolStripMenuItem.Name = "dFGDFToolStripMenuItem";
            dFGDFToolStripMenuItem.Size = new Size(130, 54);
            dFGDFToolStripMenuItem.Text = "ALTA";
            dFGDFToolStripMenuItem.Click += dFGDFToolStripMenuItem_Click;
            // 
            // sOCIOSToolStripMenuItem
            // 
            sOCIOSToolStripMenuItem.Name = "sOCIOSToolStripMenuItem";
            sOCIOSToolStripMenuItem.Size = new Size(215, 36);
            sOCIOSToolStripMenuItem.Text = "SOCIOS";
            // 
            // nOSOCIOSToolStripMenuItem
            // 
            nOSOCIOSToolStripMenuItem.Name = "nOSOCIOSToolStripMenuItem";
            nOSOCIOSToolStripMenuItem.Size = new Size(215, 36);
            nOSOCIOSToolStripMenuItem.Text = "NO SOCIOS";
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
            pictureBox1.Location = new Point(558, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 308);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 174);
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
            txtBienvenida.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtBienvenida.ForeColor = Color.White;
            txtBienvenida.Location = new Point(73, 239);
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
            ClientSize = new Size(995, 540);
            Controls.Add(txtBienvenida);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += FormInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
    }
}