using CentroDeportivo1E.Helpers;
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
    public partial class FormImpresiones : Form
    {
        public FormImpresiones()
        {
            InitializeComponent();
        }
        
        SocioService socioService = new SocioService();
        DataTable dtSocios;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                int idSocio = (int)cmbSocio.SelectedValue;

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void cargarComboBoxes()
        {
            dtSocios = socioService.traerSociosActivos();

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

        private void FormImpresiones_Load(object sender, EventArgs e)
        {
            cargarComboBoxes();
        }
    }
}
