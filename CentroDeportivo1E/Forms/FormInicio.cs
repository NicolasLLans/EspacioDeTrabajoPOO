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
            txtBienvenida.Multiline = true;
            txtBienvenida.Text = nombre + Environment.NewLine + apellido;
        }

    }
}
