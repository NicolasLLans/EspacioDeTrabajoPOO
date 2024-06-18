using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net;

namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaSocio : Form
    {
        private readonly SocioService socioService;
        public FormAltaSocio()
        {
            InitializeComponent();
            socioService = new SocioService();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                bool socioExistente = socioService.ExisteSocio(Convert.ToInt64(txtDNI.Text.Trim()));

                // Verifica si se encontró un socio con el mismo DNI
                if (socioExistente)
                {
                    MessageBox.Show("Ya existe un socio activo con el DNI: " + txtDNI.Text.Trim(), "Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                        string.IsNullOrWhiteSpace(txtApellido.Text) ||
                        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                        string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                        string.IsNullOrWhiteSpace(txtDNI.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Socio nuevoSocio = new Socio()
                    {
                        Nombre = txtNombre.Text.ToUpper().Trim(),
                        Apellido = txtApellido.Text.ToUpper().Trim(),
                        Direccion = txtDireccion.Text.ToUpper().Trim(),
                        Telefono = Convert.ToInt64(txtTelefono.Text),
                        Email = txtEmail.Text.Trim(),
                        Dni = Convert.ToInt64(txtDNI.Text.Trim()),
                        AptoFisico = cmbAptoFisico.SelectedItem.ToString().ToUpper() == "SI",
                        FechaAlta = DateTime.Now,
                    };

                    socioService.InsertarSocio(nuevoSocio);

                    DialogResult resultado = MessageBox.Show("Socio creado correctamente. ¿Desea imprimir el carnet?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Usar las credenciales para crear una instancia de SocioService
                        SocioService socioService = new SocioService();
                        DataTable dataTable = socioService.TraerSocioPorDni(nuevoSocio.Dni);

                        string id = "";
                        string nombre = "";
                        string apellido = "";
                        string fechaAlta = "";
                        foreach (DataRow fila in dataTable.Rows)
                        {
                            id = fila["NumeroSocio"].ToString();
                            nombre = fila["Nombre"].ToString();
                            apellido = fila["Apellido"].ToString();
                            fechaAlta = fila["FechaAlta"].ToString();
                        }

                        // Obtener la ruta del archivo HTML de la plantilla
                        string templateFileName = "member-card.html";
                        string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", templateFileName);
                        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Carnet_{id}.pdf");

                        // Generar el PDF del carnet
                        nuevoSocio.GenerarCarnetPdf(templatePath, outputPath, nuevoSocio.Dni);

                        MessageBox.Show("Carnet generado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de entrada no válido: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
