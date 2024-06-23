using CentroDeportivo1E.Services;
using MySql.Data.MySqlClient;

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

            ConexionMysql.Initialize(servidor, puerto, baseDatos, usuario, contrasena);
            var con = ConexionMysql.getInstance();
            try
            {
                con.AbrirConexion();
                con.CerrarConexion();
                MessageBox.Show("Conexión exitosa.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se pudo conectar a la Base de datos.  \nError:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
