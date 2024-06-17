using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaEmpleado : Form
    {
        private readonly EmpleadoHelper empleadoHelper = new EmpleadoHelper();
        private readonly EmpleadoService empleadoService;

        public FormAltaEmpleado()
        {
            InitializeComponent();
            empleadoService = new EmpleadoService();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioExistente = empleadoService.ExisteUsuario(txtUsuario.Text.Trim().ToUpper());

            if (usuarioExistente)
            {
                MessageBox.Show("El usuario ya existe.", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar campos incompletos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(cmbPuesto.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un nuevo empleado
                Empleado nuevoEmpleado = new Empleado
                {
                    Nombre = txtNombre.Text.ToUpper().Trim(),
                    Apellido = txtApellido.Text.ToUpper().Trim(),
                    Puesto = cmbPuesto.Text.ToUpper().Trim(),
                    Telefono = Convert.ToInt64(txtTelefono.Text.Trim()),
                    Usuario = txtUsuario.Text.ToUpper().Trim(),
                    Dni = Convert.ToInt64(txtDNI.Text.Trim()),
                    Direccion = txtDireccion.Text.ToUpper().Trim(),
                    Email = txtEmail.Text.ToUpper().Trim(),
                    Contrasena = empleadoHelper.encriptarContrasena(txtContrasena.Text),
                    FechaAlta = DateTime.Now,
                };

                empleadoService.InsertarEmpleado(nuevoEmpleado);

                MessageBox.Show("Usuario creado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormAltaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
