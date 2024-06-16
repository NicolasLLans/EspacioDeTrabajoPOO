
﻿using System;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using DinkToPdf;
using DinkToPdf.Contracts;
using CentroDeportivo1E.Services;
using System.Data;

namespace CentroDeportivo1E.Models
{
    internal class Socio : Persona
    {
        public int NumeroSocio { get; set; }
        public bool Activo { get; set; }
        public decimal CuotaMensual { get; set; }

        [ForeignKey("Persona")]
        public int FkPersona { get; set; }

        public Persona Persona { get; set; }


        // Método para generar el carnet en formato PDF
        public void GenerarCarnetPdf(string templatePath, string outputPath, long dni)
        {
            string htmlTemplate = File.ReadAllText(templatePath);
            // Ruta relativa a la imagen
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "img", "logo-bn.png");


            System.Data.DataTable dataTable = new SocioService().TraerSocioPorDni(dni);
            string id="";
            string nombre="";
            string apellido="";
            string fechaAlta="";
            foreach (DataRow fila in dataTable.Rows) {
                id = (fila["NumeroSocio"]).ToString();
                nombre = (fila["Nombre"]).ToString();
                apellido = fila["Apellido"].ToString();
                fechaAlta = fila["FechaAlta"].ToString();


            }
            string htmlContent = htmlTemplate
                .Replace("{Nombre}", nombre + " " + apellido)
                .Replace("{DNI}", dni.ToString())
                .Replace("{NumeroSocio}", id)
                .Replace("{FechaAlta}", fechaAlta.ToString())
                .Replace("{ImagePath}", imagePath);

            // Assuming you have a method to convert HTML to PDF
            ConvertHtmlToPdf(htmlContent, outputPath);

            // Automatically open the PDF file after creation
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = outputPath,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void ConvertHtmlToPdf(string htmlContent, string outputPath)
        {
            var converter = new SynchronizedConverter(new PdfTools());
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = DinkToPdf.Orientation.Portrait,
                    PaperSize = PaperKind.A4
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = htmlContent,
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            byte[] pdf = converter.Convert(doc);
            File.WriteAllBytes(outputPath, pdf);
        }


    }
}


