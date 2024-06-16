using CentroDeportivo1E.Services;
using System;
using System.Data;
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

            dtSociosConCuotaVencida = pagosService.ListadoSociosFechaVencimiento(fechaInicio, fechaFin);
            dgvListaVencimientos.DataSource = dtSociosConCuotaVencida;

            foreach (DataColumn column in dtSociosConCuotaVencida.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            // Ajustar las columnas del DataGridView según sea necesario
            dgvListaVencimientos.Columns["IdPersona"].Visible = false;
            dgvListaVencimientos.Columns["FechaVencimiento"].Width = 100;
            dgvListaVencimientos.Columns["Nombre"].Width = 200;
            dgvListaVencimientos.Columns["Apellido"].Width = 200;
            dgvListaVencimientos.Columns["Direccion"].Width = 200;
            dgvListaVencimientos.Columns["Telefono"].Width = 100;
            dgvListaVencimientos.Columns["Email"].Width = 200;
            dgvListaVencimientos.RowHeadersVisible = false;
        }
    }
}
