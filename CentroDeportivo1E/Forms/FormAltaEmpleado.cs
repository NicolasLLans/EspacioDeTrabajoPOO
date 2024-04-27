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
          
            LimpiarCampos();
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
