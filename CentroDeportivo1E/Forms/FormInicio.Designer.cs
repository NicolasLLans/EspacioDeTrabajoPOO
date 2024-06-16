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
            AltaToolStripMenuItem = new ToolStripMenuItem();
            SociosToolStripMenuItem = new ToolStripMenuItem();
            NoSociosToolStripMenuItem = new ToolStripMenuItem();
            PersonalToolStripMenuItem = new ToolStripMenuItem();
            ActividadesToolStripMenuItem1 = new ToolStripMenuItem();
            iNSCRIBIRToolStripMenuItem = new ToolStripMenuItem();
            ActividadSociosToolStripMenuItem = new ToolStripMenuItem();
            PagoToolStripMenuItem = new ToolStripMenuItem();
            VerToolStripMenuItem = new ToolStripMenuItem();
            VencimientosToolStripMenuItem = new ToolStripMenuItem();
            iMPRESIONESToolStripMenuItem = new ToolStripMenuItem();
            cARNETToolStripMenuItem = new ToolStripMenuItem();
            fORMULARIOALTASOCIOToolStripMenuItem = new ToolStripMenuItem();
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
            msOpciones.Items.AddRange(new ToolStripItem[] { AltaToolStripMenuItem, iNSCRIBIRToolStripMenuItem, PagoToolStripMenuItem, VerToolStripMenuItem, VencimientosToolStripMenuItem, iMPRESIONESToolStripMenuItem });
            msOpciones.Location = new Point(0, 0);
            msOpciones.Name = "msOpciones";
            msOpciones.Padding = new Padding(7, 3, 0, 3);
            msOpciones.RenderMode = ToolStripRenderMode.System;
            msOpciones.Size = new Size(1625, 60);
            msOpciones.TabIndex = 0;
            msOpciones.Text = "menuStrip1";
            // 
            // AltaToolStripMenuItem
            // 
            AltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SociosToolStripMenuItem, NoSociosToolStripMenuItem, PersonalToolStripMenuItem, ActividadesToolStripMenuItem1 });
            AltaToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            AltaToolStripMenuItem.Image = Properties.Resources.IconoAgregar;
            AltaToolStripMenuItem.Name = "AltaToolStripMenuItem";
            AltaToolStripMenuItem.Size = new Size(150, 54);
            AltaToolStripMenuItem.Text = "ALTA";
            // 
            // SociosToolStripMenuItem
            // 
            SociosToolStripMenuItem.Name = "SociosToolStripMenuItem";
            SociosToolStripMenuItem.Size = new Size(299, 46);
            SociosToolStripMenuItem.Text = "SOCIOS";
            SociosToolStripMenuItem.Click += SociosToolStripMenuItem_Click;
            // 
            // NoSociosToolStripMenuItem
            // 
            NoSociosToolStripMenuItem.Name = "NoSociosToolStripMenuItem";
            NoSociosToolStripMenuItem.Size = new Size(299, 46);
            NoSociosToolStripMenuItem.Text = "NO SOCIOS";
            NoSociosToolStripMenuItem.Click += NoSociosToolStripMenuItem_Click;
            // 
            // PersonalToolStripMenuItem
            // 
            PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem";
            PersonalToolStripMenuItem.Size = new Size(299, 46);
            PersonalToolStripMenuItem.Text = "EMPLEADO";
            PersonalToolStripMenuItem.Click += PersonalToolStripMenuItem_Click;
            // 
            // ActividadesToolStripMenuItem1
            // 
            ActividadesToolStripMenuItem1.Name = "ActividadesToolStripMenuItem1";
            ActividadesToolStripMenuItem1.Size = new Size(299, 46);
            ActividadesToolStripMenuItem1.Text = "ACTIVIDADES";
            ActividadesToolStripMenuItem1.Click += ActividadesToolStripMenuItem1_Click;
            // 
            // iNSCRIBIRToolStripMenuItem
            // 
            iNSCRIBIRToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ActividadSociosToolStripMenuItem });
            iNSCRIBIRToolStripMenuItem.Image = Properties.Resources.icons8_autógrafo_45;
            iNSCRIBIRToolStripMenuItem.Name = "iNSCRIBIRToolStripMenuItem";
            iNSCRIBIRToolStripMenuItem.Size = new Size(223, 54);
            iNSCRIBIRToolStripMenuItem.Text = "INSCRIBIR";
            // 
            // ActividadSociosToolStripMenuItem
            // 
            ActividadSociosToolStripMenuItem.Name = "ActividadSociosToolStripMenuItem";
            ActividadSociosToolStripMenuItem.Size = new Size(381, 46);
            ActividadSociosToolStripMenuItem.Text = "ACTIVIDAD SOCIOS";
            ActividadSociosToolStripMenuItem.Click += ActividadSociosToolStripMenuItem_Click;
            // 
            // PagoToolStripMenuItem
            // 
            PagoToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            PagoToolStripMenuItem.Image = Properties.Resources.iconoDinero;
            PagoToolStripMenuItem.Name = "PagoToolStripMenuItem";
            PagoToolStripMenuItem.Size = new Size(162, 54);
            PagoToolStripMenuItem.Text = "PAGO";
            // 
            // VerToolStripMenuItem
            // 
            VerToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            VerToolStripMenuItem.Image = Properties.Resources.iconoListar;
            VerToolStripMenuItem.Name = "VerToolStripMenuItem";
            VerToolStripMenuItem.Size = new Size(136, 54);
            VerToolStripMenuItem.Text = "VER";
            // 
            // VencimientosToolStripMenuItem
            // 
            VencimientosToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            VencimientosToolStripMenuItem.Image = Properties.Resources.iconoVencimiento;
            VencimientosToolStripMenuItem.Name = "VencimientosToolStripMenuItem";
            VencimientosToolStripMenuItem.Size = new Size(299, 54);
            VencimientosToolStripMenuItem.Text = "VENCIMIENTOS";
            VencimientosToolStripMenuItem.Click += VencimientosToolStripMenuItem_Click;
            // 
            // iMPRESIONESToolStripMenuItem
            // 
            iMPRESIONESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cARNETToolStripMenuItem, fORMULARIOALTASOCIOToolStripMenuItem });
            iMPRESIONESToolStripMenuItem.Name = "iMPRESIONESToolStripMenuItem";
            iMPRESIONESToolStripMenuItem.Size = new Size(225, 54);
            iMPRESIONESToolStripMenuItem.Text = "IMPRESIONES";
            // 
            // cARNETToolStripMenuItem
            // 
            cARNETToolStripMenuItem.Name = "cARNETToolStripMenuItem";
            cARNETToolStripMenuItem.Size = new Size(310, 46);
            cARNETToolStripMenuItem.Text = "CARNET";
            cARNETToolStripMenuItem.Click += cARNETToolStripMenuItem_Click;
            // 
            // fORMULARIOALTASOCIOToolStripMenuItem
            // 
            fORMULARIOALTASOCIOToolStripMenuItem.Name = "fORMULARIOALTASOCIOToolStripMenuItem";
            fORMULARIOALTASOCIOToolStripMenuItem.Size = new Size(310, 46);
            fORMULARIOALTASOCIOToolStripMenuItem.Text = "F° ALTA SOCIO";
            fORMULARIOALTASOCIOToolStripMenuItem.Click += fORMULARIOALTASOCIOToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoClub;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1011, 156);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 548);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(488, 205);
            label1.Name = "label1";
            label1.Size = new Size(315, 60);
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
            txtBienvenida.Location = new Point(387, 312);
            txtBienvenida.Margin = new Padding(3, 4, 3, 4);
            txtBienvenida.Multiline = true;
            txtBienvenida.Name = "txtBienvenida";
            txtBienvenida.ReadOnly = true;
            txtBienvenida.Size = new Size(520, 324);
            txtBienvenida.TabIndex = 3;
            txtBienvenida.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 18, 30);
            ClientSize = new Size(1625, 875);
            Controls.Add(txtBienvenida);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(msOpciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem AltaToolStripMenuItem;
        private ToolStripMenuItem PagoToolStripMenuItem;
        private ToolStripMenuItem VerToolStripMenuItem;
        private ToolStripMenuItem VencimientosToolStripMenuItem;
        private ToolStripMenuItem SociosToolStripMenuItem;
        private ToolStripMenuItem NoSociosToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBienvenida;
        private ToolStripMenuItem PersonalToolStripMenuItem;
        private ToolStripMenuItem iNSCRIBIRToolStripMenuItem;
        private ToolStripMenuItem ActividadSociosToolStripMenuItem;
        private ToolStripMenuItem ActividadesToolStripMenuItem1;
        private ToolStripMenuItem iMPRESIONESToolStripMenuItem;
        private ToolStripMenuItem cARNETToolStripMenuItem;
        private ToolStripMenuItem fORMULARIOALTASOCIOToolStripMenuItem;
    }
}