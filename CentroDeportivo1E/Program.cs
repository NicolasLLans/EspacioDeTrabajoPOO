using CentroDeportivo1E.Forms;
using CentroDeportivo1E.Models;


namespace CentroDeportivo1E
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            
            bool modDebug= false;

            if (modDebug ==false) { 
            FormLogin login = new FormLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Empleado empleado = login.IngresoPersonal();

                Application.Run(new FormInicio(empleado.Nombre, empleado.Apellido));
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}