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
            toolStripMenuItem1 = new ToolStripMenuItem();
            carnetSocioToolStripMenuItem = new ToolStripMenuItem();
            formularioDeAltaToolStripMenuItem = new ToolStripMenuItem();
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
            msOpciones.Items.AddRange(new ToolStripItem[] { AltaToolStripMenuItem, toolStripMenuItem1, iNSCRIBIRToolStripMenuItem, PagoToolStripMenuItem, VerToolStripMenuItem, VencimientosToolStripMenuItem });
            msOpciones.Location = new Point(0, 0);
            msOpciones.Name = "msOpciones";
            msOpciones.RenderMode = ToolStripRenderMode.System;
            msOpciones.Size = new Size(1422, 58);
            msOpciones.TabIndex = 0;
            msOpciones.Text = "menuStrip1";
            // 
            // AltaToolStripMenuItem
            // 
            AltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SociosToolStripMenuItem, NoSociosToolStripMenuItem, PersonalToolStripMenuItem, ActividadesToolStripMenuItem1 });
            AltaToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            AltaToolStripMenuItem.Image = Properties.Resources.IconoAgregar;
            AltaToolStripMenuItem.Name = "AltaToolStripMenuItem";
            AltaToolStripMenuItem.Size = new Size(130, 54);
            AltaToolStripMenuItem.Text = "ALTA";
            // 
            // SociosToolStripMenuItem
            // 
            SociosToolStripMenuItem.Name = "SociosToolStripMenuItem";
            SociosToolStripMenuItem.Size = new Size(236, 36);
            SociosToolStripMenuItem.Text = "SOCIOS";
            SociosToolStripMenuItem.Click += SociosToolStripMenuItem_Click;
            // 
            // NoSociosToolStripMenuItem
            // 
            NoSociosToolStripMenuItem.Name = "NoSociosToolStripMenuItem";
            NoSociosToolStripMenuItem.Size = new Size(236, 36);
            NoSociosToolStripMenuItem.Text = "NO SOCIOS";
            NoSociosToolStripMenuItem.Click += NoSociosToolStripMenuItem_Click;
            // 
            // PersonalToolStripMenuItem
            // 
            PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem";
            PersonalToolStripMenuItem.Size = new Size(236, 36);
            PersonalToolStripMenuItem.Text = "EMPLEADO";
            PersonalToolStripMenuItem.Click += PersonalToolStripMenuItem_Click;
            // 
            // ActividadesToolStripMenuItem1
            // 
            ActividadesToolStripMenuItem1.Name = "ActividadesToolStripMenuItem1";
            ActividadesToolStripMenuItem1.Size = new Size(236, 36);
            ActividadesToolStripMenuItem1.Text = "ACTIVIDADES";
            ActividadesToolStripMenuItem1.Click += ActividadesToolStripMenuItem1_Click;
            // 
            // iNSCRIBIRToolStripMenuItem
            // 
            iNSCRIBIRToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ActividadSociosToolStripMenuItem });
            iNSCRIBIRToolStripMenuItem.Image = Properties.Resources.icons8_autógrafo_45;
            iNSCRIBIRToolStripMenuItem.Name = "iNSCRIBIRToolStripMenuItem";
            iNSCRIBIRToolStripMenuItem.Size = new Size(188, 54);
            iNSCRIBIRToolStripMenuItem.Text = "INSCRIBIR";
            // 
            // ActividadSociosToolStripMenuItem
            // 
            ActividadSociosToolStripMenuItem.Name = "ActividadSociosToolStripMenuItem";
            ActividadSociosToolStripMenuItem.Size = new Size(302, 36);
            ActividadSociosToolStripMenuItem.Text = "ACTIVIDAD SOCIOS";
            ActividadSociosToolStripMenuItem.Click += ActividadSociosToolStripMenuItem_Click;
            // 
            // PagoToolStripMenuItem
            // 
            PagoToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            PagoToolStripMenuItem.Image = Properties.Resources.iconoDinero;
            PagoToolStripMenuItem.Name = "PagoToolStripMenuItem";
            PagoToolStripMenuItem.Size = new Size(139, 54);
            PagoToolStripMenuItem.Text = "PAGO";
            PagoToolStripMenuItem.Click += PagoToolStripMenuItem_Click;
            // 
            // VerToolStripMenuItem
            // 
            VerToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            VerToolStripMenuItem.Image = Properties.Resources.iconoListar;
            VerToolStripMenuItem.Name = "VerToolStripMenuItem";
            VerToolStripMenuItem.Size = new Size(118, 54);
            VerToolStripMenuItem.Text = "VER";
            VerToolStripMenuItem.Visible = false;
            // 
            // VencimientosToolStripMenuItem
            // 
            VencimientosToolStripMenuItem.ForeColor = Color.FromArgb(6, 18, 30);
            VencimientosToolStripMenuItem.Image = Properties.Resources.iconoVencimiento;
            VencimientosToolStripMenuItem.Name = "VencimientosToolStripMenuItem";
            VencimientosToolStripMenuItem.Size = new Size(245, 54);
            VencimientosToolStripMenuItem.Text = "VENCIMIENTOS";
            VencimientosToolStripMenuItem.Click += VencimientosToolStripMenuItem_Click_1;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { carnetSocioToolStripMenuItem, formularioDeAltaToolStripMenuItem });
            toolStripMenuItem1.Image = Properties.Resources.printIcon;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(227, 54);
            toolStripMenuItem1.Text = "IMPRESIONES";
            // 
            // carnetSocioToolStripMenuItem
            // 
            carnetSocioToolStripMenuItem.Name = "carnetSocioToolStripMenuItem";
            carnetSocioToolStripMenuItem.Size = new Size(338, 36);
            carnetSocioToolStripMenuItem.Text = "CARNET SOCIO";
            carnetSocioToolStripMenuItem.Click += carnetSocioToolStripMenuItem_Click;
            // 
            // formularioDeAltaToolStripMenuItem
            // 
            formularioDeAltaToolStripMenuItem.Name = "formularioDeAltaToolStripMenuItem";
            formularioDeAltaToolStripMenuItem.Size = new Size(338, 36);
            formularioDeAltaToolStripMenuItem.Text = "FORMULARIO DE ALTA";
            formularioDeAltaToolStripMenuItem.Click += formularioDeAltaToolStripMenuItem_Click;
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
            label1.Location = new Point(318, 154);
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
            txtBienvenida.Location = new Point(72, 234);
            txtBienvenida.Multiline = true;
            txtBienvenida.Name = "txtBienvenida";
            txtBienvenida.ReadOnly = true;
            txtBienvenida.Size = new Size(737, 243);
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
            Text = "Inicio";
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem carnetSocioToolStripMenuItem;
        private ToolStripMenuItem formularioDeAltaToolStripMenuItem;
    }
}