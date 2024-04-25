using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormLogin : Form
    {
        private readonly EmpleadoService empleadoService;
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
            empleadoService= new EmpleadoService();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleado empleado = empleadoService.CrearEmpleado();

            if ( txtUsuario.Text == empleado.Usuario && txtContrasena.Text== empleado.Contrasena) {

                DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
    
}
