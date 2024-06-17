﻿using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    internal partial class FormLogin : Form
    {
        private readonly EmpleadoService empleadoService;
        private EmpleadoHelper empleadoHelper = new EmpleadoHelper();
        public string Usuario { get; private set; }
        public string Contrasena { get; private set; }

        internal FormLogin(EmpleadoService empleadoService)
        {
            InitializeComponent();
            this.empleadoService = empleadoService;
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
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtUsuario.Focus();
            }
        }
    }
}
