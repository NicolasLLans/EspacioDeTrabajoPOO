using CentroDeportivo1E.Helpers;

namespace CentroDeportivo1E.Forms
{
    public partial class FormInicio : Form
    {
        private readonly string nombre;
        private readonly string apellido;

        public FormInicio(string nombre, string apellido)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            txtBienvenida.Text = $"{nombre}{Environment.NewLine}{apellido}";
        }

        private void PersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado formAltaPersonal = new FormAltaEmpleado();
            formAltaPersonal.ShowDialog();
        }

        private void SociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaSocio formAltaSocio = new FormAltaSocio();
            formAltaSocio.ShowDialog();
        }

        private void ActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAltaActividades formAltaActividades = new FormAltaActividades();
            formAltaActividades.ShowDialog();
        }

        private void ActividadSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscribirEnUnaActividad formInscribirActividad = new FormInscribirEnUnaActividad();
            formInscribirActividad.ShowDialog();
        }

        private void NoSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaNoSocio formAltaNoSocios = new FormAltaNoSocio();
            formAltaNoSocios.ShowDialog();
        }

        private void PagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagoCuota formPagoCuota = new FormPagoCuota();
            formPagoCuota.ShowDialog();
        }

        private void VencimientosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormVencimientoDiarioSocios formVencimientoDiarioSocios = new FormVencimientoDiarioSocios();
            formVencimientoDiarioSocios.ShowDialog();
        }

        private void carnetSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para imprimir el carnet de socio
            FormImpresiones formImpresiones = new FormImpresiones();
            formImpresiones.ShowDialog();
        }

        private void formularioDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDFGenerator.GenerateRegistrationForm();
        }
    }
}
