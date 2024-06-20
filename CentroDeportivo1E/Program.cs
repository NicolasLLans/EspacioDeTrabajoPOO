using CentroDeportivo1E.Forms;

namespace CentroDeportivo1E
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //FormConexion formConexion = new FormConexion();
            try
            {
                var frmConexion = new FormConexion();

                if (frmConexion.ShowDialog() != DialogResult.OK) throw new Exception();

                var frmLogin = new FormLogin();
                if (frmLogin.ShowDialog() != DialogResult.OK) throw new Exception();

                var frmInicio = new FormInicio(frmLogin.NombreUsuario, frmLogin.ApellidoUsuario);
                if (frmInicio.ShowDialog() != DialogResult.OK) throw new Exception();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }
    }
}
