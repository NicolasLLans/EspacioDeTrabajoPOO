using CentroDeportivo1E.Forms;
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FormConexion formConexion = new FormConexion();
            if (formConexion.ShowDialog() == DialogResult.OK)
            {
                EmpleadoService empleadoService = new EmpleadoService();

                FormLogin login = new FormLogin(empleadoService);

                if (login.ShowDialog() == DialogResult.OK)
                {
                    Empleado empleado = empleadoService.BuscarUsuarioInicioSesion(login.Usuario, login.Contrasena);

                    if (empleado != null)
                    {
                        Application.Run(new FormInicio(empleado.Nombre, empleado.Apellido));
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
