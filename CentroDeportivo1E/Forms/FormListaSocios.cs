using CentroDeportivo1E.Models;
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

namespace CentroDeportivo1E.Forms
{
    public partial class FormListaSocios : Form
    {
        SocioService socioService = new SocioService();
        public FormListaSocios()
        {
            InitializeComponent();
        }

        private void MostrarTodosLosSocios()
        {
            List<Socio> socios = socioService.ObtenerTodosLosSocios();

            dgvListaSocios.Rows.Clear();

            if (socios != null && socios.Count > 0)
            {

                if (dgvListaSocios.Columns.Count == 0)
                {
                    ConfigurarDgv();
                }

                foreach (Socio socio in socios)
                {
                    dgvListaSocios.Rows.Add(socio.NumeroSocio, socio.Nombre, socio.Apellido,
                                            socio.Telefono, socio.Direccion, socio.FechaAlta.ToString("dd/MM/yyyy"),
                                            socio.Activo ? "SI" : "NO", socio.CuotaMensual);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron socios.");
            }
        }

        private void MostrarLosSociosPorNombre()
        {
            List<Socio> socios = socioService.ObtenerSociosPorNombre(txtNombre.Text);

            dgvListaSocios.Rows.Clear();

            if (socios != null && socios.Count > 0)
            {

                if (dgvListaSocios.Columns.Count == 0)
                {
                    ConfigurarDgv();
                }

                foreach (Socio socio in socios)
                {
                    dgvListaSocios.Rows.Add(socio.NumeroSocio, socio.Nombre, socio.Apellido,
                                            socio.Telefono, socio.Direccion, socio.FechaAlta.ToString("dd/MM/yyyy"),
                                            socio.Activo ? "SI" : "NO", socio.CuotaMensual);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron socios.");
            }
        }

        private void MostrarLosSociosPorApellido()
        {
            List<Socio> socios = socioService.ObtenerSociosPorApellido(txtApellido.Text);

            dgvListaSocios.Rows.Clear();

            if (socios != null && socios.Count > 0)
            {

                if (dgvListaSocios.Columns.Count == 0)
                {
                    ConfigurarDgv();
                }

                foreach (Socio socio in socios)
                {
                    dgvListaSocios.Rows.Add(socio.NumeroSocio, socio.Nombre, socio.Apellido,
                                            socio.Telefono, socio.Direccion, socio.FechaAlta.ToString("dd/MM/yyyy"),
                                            socio.Activo ? "SI" : "NO", socio.CuotaMensual);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron socios.");
            }
        }

        private void MostrarLosSociosPorNobreApellido()
        {
            List<Socio> socios = socioService.ObtenerSociosPorNombreApellido(txtNombre.Text, txtApellido.Text);

            dgvListaSocios.Rows.Clear();

            if (socios != null && socios.Count > 0)
            {

                if (dgvListaSocios.Columns.Count == 0)
                {
                    ConfigurarDgv();
                }

                foreach (Socio socio in socios)
                {
                    dgvListaSocios.Rows.Add(socio.NumeroSocio, socio.Nombre, socio.Apellido,
                                            socio.Telefono, socio.Direccion, socio.FechaAlta.ToString("dd/MM/yyyy"),
                                            socio.Activo ? "SI" : "NO", socio.CuotaMensual);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron socios.");
            }
        }



        //boton buscar para hacer la busqueda de acuerdo a que campos estan completos en el formulario
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text))
            {
                MostrarLosSociosPorNobreApellido();
            }
            else if (!string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text))
            {
                MostrarLosSociosPorNombre();
            }
            else if (string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text))
            {
                MostrarLosSociosPorApellido();
            }
            else
            {
                MostrarTodosLosSocios();
            }
        }

        private void ConfigurarDgv()
        {
            //se agregan nombres a las columnas donde van a ir las variables. 
            dgvListaSocios.Columns.Add("NumeroSocio", "Nro Socio");
            dgvListaSocios.Columns.Add("Nombre", "Nombre");
            dgvListaSocios.Columns.Add("Apellido", "Apellido");
            dgvListaSocios.Columns.Add("Telefono", "Teléfono");
            dgvListaSocios.Columns.Add("Direccion", "Dirección");
            dgvListaSocios.Columns.Add("FechaAlta", "Fecha de Alta");
            dgvListaSocios.Columns.Add("Activo", "Activo");
            dgvListaSocios.Columns.Add("CuotaMensual", "Valor Cuota");


            //configuro el tamaño de las columnas

            dgvListaSocios.Columns["NumeroSocio"].Width = 50;
            dgvListaSocios.Columns["Activo"].Width = 50;
            dgvListaSocios.Columns["CuotaMensual"].Width = 100;
            dgvListaSocios.Columns["Nombre"].Width = 150;
            dgvListaSocios.Columns["Apellido"].Width = 150;
            dgvListaSocios.Columns["Direccion"].Width = 150;

            //configuro la alineacion del contenido por columna

            dgvListaSocios.Columns["NumeroSocio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["NumeroSocio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["Activo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["Activo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["CuotaMensual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaSocios.Columns["CuotaMensual"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["FechaAlta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaSocios.Columns["FechaAlta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaSocios.RowHeadersVisible = false;
        }

      
    }
}
