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
using CentroDeportivo1E.Services;
using CentroDeportivo1E.Forms;
using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;

namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaActividades : Form
    {
        ActividadService actividadService = new ActividadService();
        public FormAltaActividades()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Actividad actividadExistente = actividadService.BuscarActividad(txtDescripcionActividad.Text.ToUpper().Trim());

            // Verifica si se encontró un socio con el mismo nombre y apellido
            if (actividadExistente != null)
            {
                MessageBox.Show("Ya existe una actividad con ese nombre: " + txtDescripcionActividad.Text.ToUpper().Trim(), "Actividad Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionActividad.Text) ||
                string.IsNullOrWhiteSpace(txtIngresoValor.Text))
                
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // obtengo el ultimo numero socio de mi Socio.json
                int ultimoNumeroActividad = actividadService.ObtenerUltimoNumeroActividad();

                Actividad nuevaActividad =  new Actividad
                {
                    Id = ultimoNumeroActividad + 1,
                    Nombre = txtDescripcionActividad.Text.ToUpper().Trim(),
                    Precio = Convert.ToInt32 (txtIngresoValor.Text.Trim())

                };


                actividadService.AltaActividad(nuevaActividad);

                DialogResult resultado = MessageBox.Show(" Actividad creada Correctamente", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }
    }
}
