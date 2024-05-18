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
using CentroDeportivo1E.Helpers;

namespace CentroDeportivo1E.Forms
{
    public partial class FormLogin : Form
    {
        private readonly EmpleadoService empleadoService = new EmpleadoService();
        private EmpleadoHelper empleadoHelper = new EmpleadoHelper();
        public string Usuario { get; private set; }
        public string Contrasena { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = empleadoHelper.encriptarContrasena(txtContrasena.Text.Trim());

            Empleado empleado = empleadoService.BuscarUsuarioInicioSesion(usuario, contrasena);

         
            if (empleado != null)
            {
                if (usuario == empleado.Usuario && contrasena == empleado.Contrasena)
                {

                    Usuario = txtUsuario.Text;
                    Contrasena = empleadoHelper.encriptarContrasena(txtContrasena.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
    
}
