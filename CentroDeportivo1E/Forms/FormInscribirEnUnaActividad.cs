using CentroDeportivo1E.Services;
using System.Data;

namespace CentroDeportivo1E.Forms
{
    public partial class FormInscribirEnUnaActividad : Form
    {
        private readonly ActividadService actividadService;
        private readonly SocioService socioService;

        public FormInscribirEnUnaActividad()
        {
            InitializeComponent();
            actividadService = new ActividadService();
            socioService = new SocioService();
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                int idSocio = (int)cmbSocio.SelectedValue;
                int idActividad = (int)cmbActividades.SelectedValue;

                bool existeInscripcion = socioService.VerificarInscripcionExistente(idSocio, idActividad);
                int numeroActividades = socioService.VerificarLimiteActividades(idSocio);

                if (existeInscripcion)
                {
                    MessageBox.Show("El socio ya está inscrito en esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (numeroActividades >= 3)
                {
                    MessageBox.Show("El socio ya tiene el número máximo de actividades permitidas (3).");
                    return;
                }

                socioService.InsertarSocioActividad(idSocio, idActividad);
                CargarActividades(idSocio);
                MessageBox.Show("Inscripción realizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribir socio en actividad: " + ex.Message);
            }
        }

        private void FormInscribirEnUnaActividad_Load(object sender, EventArgs e)
        {
            cargarComboBoxes();
        }

        private void cargarComboBoxes()
        {
            DataTable dtActividades = actividadService.TraerTodasActividades();

            DataRow filaTodos = dtActividades.NewRow();
            filaTodos["IdActividad"] = "0";
            filaTodos["Nombre"] = "";
            dtActividades.Rows.InsertAt(filaTodos, 0);

            if (dtActividades.Rows.Count > 0)
            {
                cmbActividades.DisplayMember = "Nombre";
                cmbActividades.ValueMember = "IdActividad";
                cmbActividades.DataSource = dtActividades;
                cmbActividades.SelectedIndex = 0;
                cmbActividades.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbActividades.AutoCompleteMode = AutoCompleteMode.Suggest;
            }

            DataTable dtSocios = socioService.TraerSociosActivos();

            DataRow filaTodos1 = dtSocios.NewRow();
            filaTodos1["NumeroSocio"] = "0";
            filaTodos1["Nombre"] = "";
            dtSocios.Rows.InsertAt(filaTodos1, 0);

            if (dtSocios.Rows.Count > 0)
            {
                cmbSocio.DisplayMember = "Nombre";
                cmbSocio.ValueMember = "NumeroSocio";
                cmbSocio.DataSource = dtSocios;
                cmbSocio.SelectedIndex = 0;
                cmbSocio.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void cmbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSocio.SelectedIndex != -1)
            {
                int numeroSocio = (int)cmbSocio.SelectedValue; // Obtener el número de socio seleccionado
                CargarActividades(numeroSocio);

                DataTable actividades = socioService.TraerActividadPorNumeroSocio(numeroSocio);
                dgvActividades.DataSource = actividades;
            }
        }

        private void CargarActividades(int numeroSocio)
        {
            DataTable actividades = socioService.TraerActividadPorNumeroSocio(numeroSocio);
            dgvActividades.DataSource = actividades;

            dgvActividades.Columns["IdActividad"].Visible = false;
            dgvActividades.Columns["baja"].Visible = false;
            dgvActividades.Columns["Precio"].Visible = false;
            dgvActividades.Columns["Nombre"].Width = 290;
            dgvActividades.RowHeadersVisible = false;
        }

        private void lblSocio_Click(object sender, EventArgs e)
        {
        }
    }
}
