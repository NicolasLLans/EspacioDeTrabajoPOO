using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;
using System;
using System.Windows.Forms;

namespace CentroDeportivo1E.Forms
{
    public partial class FormInicio : Form
    {
        private readonly string nombre;
        private readonly string apellido;
        private readonly string servidor;
        private readonly string puerto;
        private readonly string baseDatos;
        private readonly string usuario;
        private readonly string contrasena;

        public FormInicio(string nombre, string apellido, string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.apellido = apellido;
            this.servidor = servidor;
            this.puerto = puerto;
            this.baseDatos = baseDatos;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            txtBienvenida.Text = $"{nombre}{Environment.NewLine}{apellido}";
        }

        private void PersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado formAltaPersonal = new FormAltaEmpleado(servidor, puerto, baseDatos, usuario, contrasena);
            formAltaPersonal.ShowDialog();
        }

        private void SociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaSocio formAltaSocio = new FormAltaSocio(servidor, puerto, baseDatos, usuario, contrasena);
            formAltaSocio.ShowDialog();
        }

        private void ActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAltaActividades formAltaActividades = new FormAltaActividades(servidor, puerto, baseDatos, usuario, contrasena);
            formAltaActividades.ShowDialog();
        }

        private void ActividadSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscribirEnUnaActividad formInscribirActividad = new FormInscribirEnUnaActividad(servidor, puerto, baseDatos, usuario, contrasena);
            formInscribirActividad.ShowDialog();
        }

        private void NoSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaNoSocio formAltaNoSocios = new FormAltaNoSocio(servidor, puerto, baseDatos, usuario, contrasena);
            formAltaNoSocios.ShowDialog();
        }

        private void PagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagoCuota formPagoCuota = new FormPagoCuota(servidor, puerto, baseDatos, usuario, contrasena);
            formPagoCuota.ShowDialog();
        }

        private void VencimientosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormVencimientoDiarioSocios formVencimientoDiarioSocios = new FormVencimientoDiarioSocios(servidor, puerto, baseDatos, usuario, contrasena);
            formVencimientoDiarioSocios.ShowDialog();
        }

        private void carnetSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para imprimir el carnet de socio
            FormImpresiones formImpresiones = new FormImpresiones(servidor, puerto, baseDatos, usuario, contrasena);
            formImpresiones.ShowDialog();
        }
    }
}
