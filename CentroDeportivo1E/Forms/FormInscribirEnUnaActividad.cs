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
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Helpers;

namespace CentroDeportivo1E.Forms
{
    public partial class FormInscribirEnUnaActividad : Form
    {
        ActividadService actividadService = new ActividadService();
        public FormInscribirEnUnaActividad()
        {
            InitializeComponent();
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            actividadService.inscribirActividad(txtActividad.Text, Convert.ToInt32(txtNumeroSocio.Text));
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
