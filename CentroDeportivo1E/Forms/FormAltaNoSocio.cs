using CentroDeportivo1E.Models;
using CentroDeportivo1E.Services;
using MySql.Data.MySqlClient;
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
    public partial class FormAltaNoSocio : Form
    {

        NoSocioService noSocioService = new NoSocioService();
        public FormAltaNoSocio()
        {
            InitializeComponent();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            try
            {
                bool socioExistente = noSocioService.ExisteNoSocio(Convert.ToInt64(txtDNI.Text.Trim()));

                // Verifica si se encontró un socio con el mismo DNI
                if (socioExistente)
                {
                    MessageBox.Show("Ya existe un socio activo con el DNI: " + txtDNI.Text.Trim(), "Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                        string.IsNullOrWhiteSpace(txtApellido.Text) ||
                        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                        string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                        string.IsNullOrWhiteSpace(txtDNI.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    NoSocio nuevoNoSocio = new NoSocio
                    {
                        Nombre = txtNombre.Text.ToUpper().Trim(),
                        Apellido = txtApellido.Text.ToUpper().Trim(),
                        Direccion = txtDireccion.Text.ToUpper().Trim(),
                        Telefono = Convert.ToInt64(txtTelefono.Text),
                        Email = txtEmail.Text.Trim(),
                        Dni = Convert.ToInt64(txtDNI.Text.Trim()),
                        AptoFisico = cmbAptoFisico.SelectedItem.ToString().ToUpper() == "SI" ? true : false,
                        FechaAlta = DateTime.Now,
                    };

                    noSocioService.InsertarNoSocio(nuevoNoSocio);

                    DialogResult resultado = MessageBox.Show(" No Socio creado correctamente", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de entrada no válido: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
