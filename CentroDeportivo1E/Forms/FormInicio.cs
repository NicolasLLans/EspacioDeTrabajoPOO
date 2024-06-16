using CentroDeportivo1E.Models;
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
    public partial class FormInicio : Form
    {
        private string nombre;
        private string apellido;

        public FormInicio(string nombre, string apellido)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.apellido = apellido;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            txtBienvenida.Text = nombre + Environment.NewLine + apellido;
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

        private void ListaSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaSocios formListaSocios = new FormListaSocios();
            formListaSocios.ShowDialog();
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

        private void VencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fORMULARIOALTASOCIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para imprimir el formulario de alta de socios
           FormImpresiones formImpresiones = new FormImpresiones();
            formImpresiones.ShowDialog();

        }

        private void cARNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para imprimir el carnet de socio

        }

   
    }

}
