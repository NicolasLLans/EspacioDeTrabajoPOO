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
        string nombre;
        string apellido;
        public FormInicio(string nombreEmpleado, string apellidoEmpleado)
        {
            InitializeComponent();
            this.nombre = nombreEmpleado;
            this.apellido= apellidoEmpleado;    
        }

       

        private void FormInicio_Load(object sender, EventArgs e)
        {
            txtBienvenido.Text = $"¡Bienvenido, {nombre} {apellido}";
        }

    
    }
}
