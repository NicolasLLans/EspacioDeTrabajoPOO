using CentroDeportivo1E.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormListaSocios : Form
    {
        SocioService socioService = new SocioService();
        public FormListaSocios()
        {
            InitializeComponent();
        }


        private void MostrarSocios()
        {
            List<Socio> socios = socioService.ObtenerTodosLosSocios();
            
            dgvListaSocios.Rows.Clear();

            if (socios != null && socios.Count > 0)
            {
             
                if (dgvListaSocios.Columns.Count == 0)
                {
                    dgvListaSocios.Columns.Add("NumeroSocio", "Número de Socio");
                    dgvListaSocios.Columns.Add("Nombre", "Nombre");
                    dgvListaSocios.Columns.Add("Apellido", "Apellido");
                    dgvListaSocios.Columns.Add("Telefono", "Teléfono");
                    dgvListaSocios.Columns.Add("Direccion", "Dirección");
                    dgvListaSocios.Columns.Add("Activo", "Activo");
                }

               
                foreach (Socio socio in socios)
                {
                    dgvListaSocios.Rows.Add(socio.NumeroSocio, socio.Nombre, socio.Apellido, socio.Telefono, socio.Direccion, socio.Activo);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron socios.");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarSocios();
        }
    }
}
