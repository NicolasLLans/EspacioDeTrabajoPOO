using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;


namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaEmpleado : Form
    {

        EmpleadoHelper empleadoHelper = new EmpleadoHelper();
        EmpleadoService empleadoService = new EmpleadoService();

        private string nombre, apellido, puesto, usuario, contrasena;
        private long telefono;
        private DateTime fechaAlta;


        public FormAltaEmpleado()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleado UsuarioExistente = empleadoService.BuscarUsuario(txtUsuario.Text.Trim().ToUpper());

            if (UsuarioExistente != null)
            {
                MessageBox.Show("usuario ya existe ", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else { 

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(cmbPuesto.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int ultimoId = empleadoService.ObtenerUltimoId();
            // Se crea Nuevo Empleado
            Empleado nuevoEmpleado = new Empleado
            {
                Id= ultimoId+1,
                Nombre = txtNombre.Text.ToUpper().Trim(),
                Apellido = txtApellido.Text.ToUpper().Trim(),
                Puesto = cmbPuesto.Text.ToUpper().Trim(),
                Telefono = Convert.ToInt64(txtTelefono.Text.ToUpper().Trim()),
                Usuario = txtUsuario.Text.ToUpper().Trim(),
                Contrasena = empleadoHelper.encriptarContrasena(txtContrasena.Text),
                FechaAlta = DateTime.Now,

            };

            empleadoService.GuardarEmpleado(nuevoEmpleado);

            MessageBox.Show("Usuario Creado Correctamente");
           
            this.Close();
             


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
    }
}
