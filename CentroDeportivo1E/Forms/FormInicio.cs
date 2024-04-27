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


        // Modifica el constructor para aceptar nombre y apellido como parámetros
        public FormInicio(string nombre, string apellido)
        {
            InitializeComponent();

            // Asigna los valores de nombre y apellido que se pasan como parámetros al constructor a las variables de la clase
            this.nombre = nombre;
            this.apellido = apellido;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            txtBienvenida.Multiline = true;
            // Utiliza las variables de clase para mostrar el nombre y apellido en el cuadro de texto al cargar el formulario
            txtBienvenida.Text = nombre + Environment.NewLine + apellido;
        }

        private void pERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado formAltaPersonal = new FormAltaEmpleado();
            formAltaPersonal.ShowDialog();

        }
    }
}
