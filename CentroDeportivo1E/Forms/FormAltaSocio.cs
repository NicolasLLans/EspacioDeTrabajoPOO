using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;



namespace CentroDeportivo1E.Forms
{
    public partial class FormAltaSocio : Form
    {
        SocioService socioService = new SocioService();
        public FormAltaSocio()
        {
            InitializeComponent();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Socio socioExistente = socioService.BuscarSocio(txtNombre.Text.ToUpper().Trim(), txtApellido.Text.ToUpper().Trim());

            // Verifica si se encontró un socio con el mismo nombre y apellido
            if (socioExistente != null)
            {
                MessageBox.Show("Ya existe un socio activo con el nombre: " + txtNombre.Text.ToUpper().Trim() + "y Apellido" + txtApellido.Text.ToUpper().Trim(), "Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // obtengo el ultimo numero socio de mi Socio.json
                long ultimoNumeroSocio = socioService.ObtenerUltimoNumeroSocio();

                Socio nuevoSocio = new Socio
                {
                    Nombre = txtNombre.Text.ToUpper().Trim(),
                    Apellido = txtApellido.Text.ToUpper().Trim(),
                    Direccion = txtDireccion.Text.ToUpper().Trim(),
                    Telefono = Convert.ToInt64(txtTelefono.Text),
                    Email = txtEmail.Text.Trim(),
                    NumeroSocio = ultimoNumeroSocio+1,
                    CuotaMensual = Convert.ToInt64(txtCuota.Text),
                    FechaAlta=DateTime.Now,
                    EstadoPago=true,
                    Activo = true,


                };


                socioService.AltaSocio(nuevoSocio);

                DialogResult resultado = MessageBox.Show(" Socio creado Correctamente", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {
            //socioService.GenerarCarnet(txtNombre.Text.ToUpper().Trim(), txtApellido.Text.ToUpper().Trim());
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
