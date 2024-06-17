using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Services;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CentroDeportivo1E.Models;

namespace CentroDeportivo1E.Forms
{
    public partial class FormImpresiones : Form
    {
        private readonly SocioService socioService;
        private readonly string servidor;
        private readonly string puerto;
        private readonly string baseDatos;
        private readonly string usuario;
        private readonly string contrasena;
        private DataTable dtSocios;

        // Modifica el constructor para recibir las credenciales de conexión
        public FormImpresiones(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            InitializeComponent();
            socioService = new SocioService(servidor, puerto, baseDatos, usuario, contrasena);
            this.servidor = servidor;
            this.puerto = puerto;
            this.baseDatos = baseDatos;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                long dni = (long)cmbSocio.SelectedValue;
                Socio socio = new Socio(servidor, puerto, baseDatos, usuario, contrasena);

                // Obtener la ruta del archivo HTML de la plantilla
                string templateFileName = "member-card.html";
                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", templateFileName);
                string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Carnet_{socio.NumeroSocio}.pdf");

                socio.GenerarCarnetPdf(templatePath, outputPath, dni);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarComboBoxes()
        {
            dtSocios = socioService.TraerSociosActivos();

            DataRow filaTodos1 = dtSocios.NewRow();
            filaTodos1["Dni"] = "0";
            filaTodos1["Nombre"] = "";
            dtSocios.Rows.InsertAt(filaTodos1, 0);

            if (dtSocios.Rows.Count > 0)
            {
                cmbSocio.DisplayMember = "Nombre";
                cmbSocio.ValueMember = "Dni";
                cmbSocio.DataSource = dtSocios;
                cmbSocio.SelectedIndex = 0;
                cmbSocio.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void FormImpresiones_Load(object sender, EventArgs e)
        {
            cargarComboBoxes();
        }
    }
}
