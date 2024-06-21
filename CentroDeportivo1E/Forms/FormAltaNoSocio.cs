using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaNoSocio : Form
    {
        private readonly PersonaService personaService;
        private readonly NoSocioService noSocioService;
        public FormAltaNoSocio()
        {
            InitializeComponent();
            noSocioService = new NoSocioService();
            personaService = new PersonaService();
        }
        private bool validarDatosForm()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return false;
            }
            return true;
        }
        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            try
            {

                if (!validarDatosForm()) throw new Exception("Por favor, complete todos los campos.");

                // Verifica si se encontró un socio con el mismo DNI
                bool socioExistente = personaService.ExistePersona(Convert.ToInt64(txtDNI.Text.Trim()));
                if (socioExistente) throw new Exception("Ya existe un cliente (Socio/No Socio) activo con el DNI:" + txtDNI.Text.Trim());

                NoSocio nuevoNoSocio = new NoSocio
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

                noSocioService.InsertarNoSocio(nuevoNoSocio);
                MessageBox.Show("No Socio creado correctamente.");

                this.Close();
               
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
