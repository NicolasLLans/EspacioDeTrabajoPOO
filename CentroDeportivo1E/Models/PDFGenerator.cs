using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace CentroDeportivo1E.Models
{
    internal class PDFGenerator
    {
        public static void GenerateRegistrationForm(string path)
        {
            string logoPath = "./CentroDeportivo1E/Resources/img/logo-bn.png";
            Document doc = new Document(PageSize.A4);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                // Agregar Logo
                Image logo = Image.GetInstance(logoPath);
                logo.SetAbsolutePosition(10, doc.PageSize.Height - 140);
                logo.ScaleToFit(120, 120);
                doc.Add(logo);


                // Agregar el titulo
                PdfPTable titleTable = new PdfPTable(1);
                titleTable.WidthPercentage = 100;

                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.DARK_GRAY);
                PdfPCell titleCell = new PdfPCell(new Phrase("Sports Club 1E\nFormulario de Inscripción", titleFont));

                titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
                titleCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                titleCell.Padding = 10;
                titleCell.PaddingLeft = 90;
                titleCell.Border = 0;

                titleTable.AddCell(titleCell);
                doc.Add(titleTable);

                //Agregar espaciado
                doc.Add(new Paragraph("\n\n\n"));

                // Crear tabla de campos
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1, 4 });
                table.SpacingBefore = 10f;
                table.SpacingAfter = 10f;


                //Agregar fecha
                PdfPCell cellDate = new PdfPCell(new Phrase("__ __/__ __/__ __ __ __"));

                cellDate.Border = 0;
                cellDate.HorizontalAlignment = Element.ALIGN_RIGHT;
                cellDate.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellDate.Padding = 5;
                cellDate.Colspan = 4;

                table.AddCell(cellDate);
                AddEmptyCell(table);
                AddEmptyCell(table);


                // Agregar subtitulo
                PdfPCell cellSubtitle = new PdfPCell(new Phrase("Datos del Cliente", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.WHITE)));

                cellSubtitle.Border = 0;
                cellSubtitle.BackgroundColor = BaseColor.DARK_GRAY;
                cellSubtitle.HorizontalAlignment = Element.ALIGN_CENTER;
                cellSubtitle.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellSubtitle.Padding = 5;
                cellSubtitle.Colspan = 3;

                table.AddCell(cellSubtitle);
                AddEmptyCell(table);
                AddEmptyCell(table);

                // Agregar campos del formulario
                Font textFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                AddLabelCell(table, "DNI:", textFont);
                AddSpaceFieldCell(table);
                AddEmptyCell(table);
                AddEmptyCell(table);

                AddLabelCell(table, "Nombre:", textFont);
                AddSpaceFieldCell(table);
                AddEmptyCell(table);
                AddEmptyCell(table);

                AddLabelCell(table, "Apellido:", textFont);
                AddSpaceFieldCell(table);
                AddEmptyCell(table);
                AddEmptyCell(table);

                AddLabelCell(table, "Dirección:", textFont);
                AddSpaceFieldCell(table);
                AddEmptyCell(table);
                AddEmptyCell(table);

                AddLabelCell(table, "Teléfono:", textFont);
                AddSpaceFieldCell(table);
                AddEmptyCell(table);
                AddEmptyCell(table);

                AddLabelCell(table, "Email:", textFont);
                AddSpaceFieldCell(table);
                AddEmptyCell(table);
                AddEmptyCell(table);

                //Agregar apto fisico
                PdfPCell newCell = new PdfPCell(new Phrase("Apto Físico?\n(Sí/No):", textFont));
                newCell.Border = 0;
                newCell.Padding = 5;
                newCell.PaddingBottom = 10;
                table.AddCell(newCell);

                //alternativa a los 2 cuadraditos de "si-no", si alguien lo sabe hacer, que lo corrija porfa
                newCell = new PdfPCell(new Phrase(" ", textFont));
                newCell.Border = Rectangle.BOX;
                newCell.Padding = 5;
                newCell.PaddingBottom = 10;
                newCell.Colspan = 1;
                table.AddCell(newCell);

                doc.Add(table);

                // Agregar espacio para la firma
                doc.Add(new Paragraph("\n\n\n"));

                Paragraph footer = new Paragraph("Firma: ___________________________", textFont);
                footer.Alignment = Element.ALIGN_RIGHT;
                doc.Add(footer);
            }
            catch (DocumentException docEx)
            {
                Console.Error.WriteLine(docEx.Message);
            }
            finally
            {
                doc.Close();
            }
        }
        public static void GeneratePaymentTicket(string path)
        {
            Document doc = new Document();
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                Font titleFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 24, Font.UNDERLINE, BaseColor.DARK_GRAY);
                Font textFont = FontFactory.GetFont(FontFactory.COURIER, 12, BaseColor.DARK_GRAY);




                //Crear tabla de contenido
                PdfPTable containTable = new PdfPTable(1);
                containTable.WidthPercentage = 100;

                //Agregar info
                AddLabelCell(containTable, "Comprobante de Pago", titleFont, "CENTER");
                AddEmptyCell(containTable);


                AddLabelCell(containTable, "Fecha @fecha", textFont, "CENTER");

                AddLabelCell(containTable, "Importe: @importe", textFont, "CENTER");

                AddLabelCell(containTable, "Nombre: @nombre", textFont, "CENTER");

                AddLabelCell(containTable, "Socio N°: @NSocio", textFont, "CENTER");

                AddLabelCell(containTable, "Recibo N°: @IdPago", textFont, "CENTER");

                AddEmptyCell(containTable);

                PdfPCell newCell = new PdfPCell(new Paragraph("Verifique que los datos contenido en este comprante correspondan con los que usted ha expresado al cajero.- \nTicket no valido como factura.", textFont));
                newCell.Padding = 10;
                newCell.Border = Rectangle.TOP_BORDER;
                containTable.AddCell(newCell);

                newCell = new PdfPCell(new Paragraph("@codigoSeguridad", textFont));
                newCell.Padding = 10;
                newCell.Border = Rectangle.TOP_BORDER;
                containTable.AddCell(newCell);

                //Crear tabla con borde
                PdfPTable borderTable = new PdfPTable(1);
                borderTable.WidthPercentage = 70;

                PdfPCell borderCell = new PdfPCell(containTable);
                borderCell.Padding = 5;
                borderCell.Border = Rectangle.BOX;
                borderTable.AddCell(borderCell);

                doc.Add(borderTable);
            }
            catch (DocumentException docEx)
            {
                Console.Error.WriteLine(docEx.Message);
            }
            finally
            {
                doc.Close();
            }

        }
        private static void AddLabelCell(PdfPTable table, string text, Font font, string horizontalAlign = "LEFT")
        {
            PdfPCell cellText = new PdfPCell(new Phrase(text, font));
            cellText.Border = 0;
            cellText.Padding = 5;
            cellText.PaddingBottom = 10;
            cellText.VerticalAlignment = Element.ALIGN_BOTTOM;

            if (horizontalAlign == "LEFT") cellText.HorizontalAlignment = Element.ALIGN_LEFT;
            if (horizontalAlign == "CENTER") cellText.HorizontalAlignment = Element.ALIGN_CENTER;
            if (horizontalAlign == "RIGHT") cellText.HorizontalAlignment = Element.ALIGN_RIGHT;

            table.AddCell(cellText);
        }
        private static void AddSpaceFieldCell(PdfPTable table)
        {
            PdfPCell cellSpace = new PdfPCell(new Phrase(" "));
            cellSpace.Border = Rectangle.BOTTOM_BORDER;
            cellSpace.BorderColor = BaseColor.LIGHT_GRAY;
            cellSpace.Padding = 5;
            cellSpace.PaddingBottom = 10;
            table.AddCell(cellSpace);
        }
        private static void AddEmptyCell(PdfPTable table)
        {
            PdfPCell emptyCell = new PdfPCell(new Phrase(" "));
            emptyCell.Border = 0;
            table.AddCell(emptyCell);
        }
    }
}
