using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaActividades : Form
    {
        private readonly ActividadService actividadService;

        public FormAltaActividades()
        {
            InitializeComponent();
            actividadService = new ActividadService();
        }

        private void FormAltaActividades_Load(object sender, EventArgs e)
        {
            cargarDatagridActividades();
        }

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtDescripcionActividad.Text.Trim().ToUpper();
                decimal precio = Convert.ToDecimal(txtIngresoValor.Text.Trim());

                // Validar la entrada del usuario
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre de la actividad no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear la nueva actividad
                Actividad nuevaActividad = new Actividad
                {
                    Nombre = nombre,
                    Precio = precio
                };

                actividadService.InsertarActividad(nuevaActividad);

                MessageBox.Show("Actividad agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridActividades();

                txtDescripcionActividad.Text = "";
                txtIngresoValor.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIngresoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }

            // Permitir números decimales (0-9), tecla de retroceso, punto decimal y punto decimal con 2 dígitos después
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') || (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.')) ||
                ((sender as TextBox).Text.Contains('.') && (sender as TextBox).Text.Split('.')[1].Length >= 2))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void cargarDatagridActividades()
        {
            dgvActividades.DataSource = actividadService.TraerTodasActividades();

            dgvActividades.Columns["IdActividad"].Visible = false;
            dgvActividades.Columns["baja"].Visible = false;
            dgvActividades.Columns["Nombre"].Width = 245;

            dgvActividades.Columns["Precio"].Width = 100;
            dgvActividades.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvActividades.Columns["Precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvActividades.RowHeadersVisible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
