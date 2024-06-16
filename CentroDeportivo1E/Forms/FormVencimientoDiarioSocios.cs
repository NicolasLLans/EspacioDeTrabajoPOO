using CentroDeportivo1E.Services;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace CentroDeportivo1E.Forms
{
    public partial class FormVencimientoDiarioSocios : Form
    {
        PagosService pagosService = new PagosService();
        DataTable dtSociosConCuotaVencida;

        public FormVencimientoDiarioSocios()
        {
            InitializeComponent();
        }

        private void FormVencimientoDiarioSocios_Load(object sender, EventArgs e)
        {

            DateTime fechaActual = DateTime.Today;
            dtpDesde.Value = fechaActual;
            dtpHasta.Value = fechaActual;
            CargarVencimientos(fechaActual, fechaActual);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusquedaClientes_TextChanged(object sender, EventArgs e)
        {
            if (dtSociosConCuotaVencida != null)
            {
                DataView dv = dtSociosConCuotaVencida.DefaultView;
                dv.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%'", txtBusquedaClientes.Text);
                dgvListaVencimientos.DataSource = dv.ToTable();
            }
        }

        private void btnBuscarCuotasVencidas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpDesde.Value.Date;
            DateTime fechaFin = dtpHasta.Value.Date;

            CargarVencimientos(fechaInicio, fechaFin);
        }

        private void CargarVencimientos(DateTime fechaInicio, DateTime fechaFin)
        {
            dtSociosConCuotaVencida = pagosService.ListadoSociosFechaVencimiento(fechaInicio, fechaFin);
            dgvListaVencimientos.DataSource = dtSociosConCuotaVencida;

            foreach (DataColumn column in dtSociosConCuotaVencida.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }


            dgvListaVencimientos.Columns["IdPersona"].Visible = false;
            dgvListaVencimientos.Columns["FechaVencimiento"].Width = 150;
            dgvListaVencimientos.Columns["Nombre"].Width = 200;
            dgvListaVencimientos.Columns["Apellido"].Width = 200;
            dgvListaVencimientos.Columns["Direccion"].Width = 200;
            dgvListaVencimientos.Columns["Telefono"].Width = 80;
            dgvListaVencimientos.Columns["Email"].Width = 200;
            dgvListaVencimientos.RowHeadersVisible = false;
        }

        private void btnAvisarVencimiento_Click(object sender, EventArgs e)
        {
            if (dgvListaVencimientos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListaVencimientos.SelectedRows[0];
                
                string telefono = selectedRow.Cells["Telefono"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                DateTime fechaVencimiento = Convert.ToDateTime(selectedRow.Cells["FechaVencimiento"].Value);

                
                string mensaje = $"Hola {nombre}, tu cuota del club vence el {fechaVencimiento.ToString("dd/MM/yyyy")}.";

               
                string url = $"https://wa.me/+54{telefono}?text={Uri.EscapeDataString(mensaje)}";

               
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir la URL de WhatsApp. Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la lista.");
            }
        }
    }
}
