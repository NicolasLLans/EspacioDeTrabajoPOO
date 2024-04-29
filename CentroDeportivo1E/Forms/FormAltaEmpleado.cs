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
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Puesto = cmbPuesto.Text,
                Telefono = Convert.ToInt64(txtTelefono.Text),
                Usuario = txtUsuario.Text,
                Contrasena = empleadoHelper.encriptarContrasena(txtContrasena.Text),
                FechaAlta = DateTime.Now,

            };

            empleadoService.GuardarEmpleado(nuevoEmpleado);

            DialogResult resultado = MessageBox.Show(" Empleado creado Correctamente ¿Desea dar de alta al nuevo empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                LimpiarCampos();
            }
            else
            {
                this.Close();
            }


        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbPuesto.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
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
