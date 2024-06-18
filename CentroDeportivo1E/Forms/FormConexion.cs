using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormConexion : Form
    {
        public FormConexion()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string servidor = textBoxServidor.Text;
            string puerto = textBoxPuerto.Text;
            string baseDatos = textBoxBaseDatos.Text;
            string usuario = textBoxUsuario.Text;
            string contrasena = textBoxContrasena.Text;

            ConexionMysql con = new ConexionMysql(servidor, puerto, baseDatos, usuario, contrasena);

            try
            {
                con.AbrirConexion();
                con.CerrarConexion();
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex) { }

        }
    }
}
