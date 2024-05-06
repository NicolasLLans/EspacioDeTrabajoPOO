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
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtActividad.Text) || string.IsNullOrWhiteSpace(txtNumeroSocio.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intentar inscribir al socio en la actividad
                string mensaje = actividadService.inscribirActividad(txtActividad.Text.ToUpper().Trim(), Convert.ToInt32(txtNumeroSocio.Text));

                // Mostrar el mensaje devuelto por el método en un MessageBox
                MessageBox.Show(mensaje, "Inscripción en Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtActividad.Clear();
                txtNumeroSocio.Clear();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Ha ocurrido un error durante la inscripción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
    }
}
