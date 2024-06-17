namespace CentroDeportivo1E.Forms
{
    public partial class FormConexion : Form
    {
        public string Servidor { get; private set; }
        public string Puerto { get; private set; }
        public string BaseDatos { get; private set; }
        public string Usuario { get; private set; }
        public string Contrasena { get; private set; }

        public FormConexion()
        {
            InitializeComponent();
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Servidor = textBoxServidor.Text;
            Puerto = textBoxPuerto.Text;
            BaseDatos = textBoxBaseDatos.Text;
            Usuario = textBoxUsuario.Text;
            Contrasena = textBoxContrasena.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
