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
        public FormPagoCuota()
        {
            InitializeComponent();
        }

        private void FormPagoCuota_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void cargarComboBox()
        {           

            DataTable dtSocios = socioService.traerSociosActivos();

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
    }
}
