using CentroDeportivo1E.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeportivo1E.Forms
{
    public partial class FormPagoCuota : Form
    {
        SocioService socioService = new SocioService();
        PagosService pagosService = new PagosService();
        DataTable dtSociosYNoSocios;
        DataTable dtPagos;
        DataTable dtTipoPago;
        public FormPagoCuota()
        {
            InitializeComponent();
        }

        private void FormPagoCuota_Load(object sender, EventArgs e)
        {
            cargarListadoSociosYNoSocios();

        }

        private void cargarListadoSociosYNoSocios()
        {
            dtSociosYNoSocios = socioService.traerListadoSociosYNoSocios();
            dgvListaClientes.DataSource = dtSociosYNoSocios;

            foreach (DataColumn column in dtSociosYNoSocios.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            dgvListaClientes.Columns["Nombre"].Width = 210;
            dgvListaClientes.Columns["Apellido"].Width = 210;

            dgvListaClientes.Columns["IdPersona"].Visible = false;
            dgvListaClientes.Columns["Direccion"].Visible = false;
            dgvListaClientes.Columns["Telefono"].Visible = false;
            dgvListaClientes.Columns["Email"].Visible = false;
            dgvListaClientes.Columns["FechaAlta"].Visible = false;
            dgvListaClientes.Columns["FechaBaja"].Visible = false;
            dgvListaClientes.Columns["AptoFisico"].Visible = false;
            dgvListaClientes.Columns["NumeroSocio"].Visible = false;
            dgvListaClientes.Columns["Baja"].Visible = false;
            dgvListaClientes.RowHeadersVisible = false;

        }

        private void txtBusquedaClientes_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtSociosYNoSocios.DefaultView;
            dv.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%'", txtBusquedaClientes.Text);
            dgvListaClientes.DataSource = dv.ToTable();
        }



        private void dgvListaClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListaClientes.SelectedRows[0];

                // obtenemos el IdPersona y cargar los pagos
                int idPersona = Convert.ToInt32(selectedRow.Cells["IdPersona"].Value);
                cargarPagos(idPersona);

                MostrarMonto(idPersona);

                // obtenemos el tipo de cliente y actualizar el DateTimePicker
                string tipo = selectedRow.Cells["Tipo"].Value.ToString();

                AjustarFechaHasta(tipo);
            }
        }

        private void AjustarFechaHasta(string tipo)
        {
            DateTime desdeFecha = dtpDesde.Value;

            if (tipo == "Socio")
            {
                dtpHasta.Value = desdeFecha.AddDays(30);
            }
            else if (tipo == "No Socio")
            {
                dtpHasta.Value = desdeFecha.AddDays(1);
            }
        }

        private void cargarPagos(int IdPersona)
        {
            dtPagos = pagosService.ListadoPagos(IdPersona);
            dgvHistorialPagos.DataSource = dtPagos;

            foreach (DataColumn column in dtPagos.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }


            dgvHistorialPagos.Columns["FechaPago"].Width = 150;
            dgvHistorialPagos.Columns["FechaVencimiento"].Width = 150;

            dgvHistorialPagos.Columns["IdPersona"].Visible = false;
            dgvHistorialPagos.Columns["IdPago"].Visible = false;
            dgvHistorialPagos.Columns["IdPago"].Visible = false;
            dgvHistorialPagos.RowHeadersVisible = false;

        }

        private void MostrarMonto(int idPersona)
        {
            DataTable dtTipoPago = pagosService.TraerTipoPago(idPersona);

            if (dtTipoPago.Rows.Count > 0)
            {

                txtMonto.Text = dtTipoPago.Rows[0]["Monto"].ToString();
            }
            else
            {
                txtMonto.Text = "0";
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

            if (dgvListaClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListaClientes.SelectedRows[0];


                string tipo = selectedRow.Cells["Tipo"].Value.ToString();


                AjustarFechaHasta(tipo);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
