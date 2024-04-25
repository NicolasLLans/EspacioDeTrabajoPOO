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

namespace CentroDeportivo1E.Forms
{
    public partial class FormLogin : Form
    {
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
           Empleado  empleado = IngresoPersonal();

            if( txtUsuario.Text == empleado.Usuario && txtContrasena.Text== empleado.Contrasena) {

                DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        internal Empleado IngresoPersonal()
        {
            Empleado empleado = new Empleado()
            {
                Id = 1,
                Nombre = "Administrador",
                Apellido = "Centro Deportivo",
                Telefono = 08001231234,
                NumeroSocio = 00001,
                Usuario = "admin",
                Contrasena = "admin",
                FechaAlta = DateTime.ParseExact("24-04-2024", "dd-MM-yyyy", null)

            };
            return empleado;

        }

    }
    
}
