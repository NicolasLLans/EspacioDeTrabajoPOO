using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeportivo1E.Services;
using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;


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
                EstadoPago= true
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

    }
}
