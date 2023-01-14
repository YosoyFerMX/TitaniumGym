using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System_Titanium.Business;
using System.Windows.Forms;
using System.IO;

namespace System_Titanium.Reportes
{
    class ReportGeneral
    {
        DataSet dsventas = new DataSet();
        decimal inversion = 0, ventas= 0, utilidad = 0, visitas = 0, mensualidades = 0, suma = 0, egresos = 0;
        public void ReporteGeneral(DateTime Desde, DateTime Hasta) {
            dsventas = Business.Reportes.ReporGenVentas(Desde, Hasta);//Se traen los Datos de ventas
            if (dsventas != null) {
                if(dsventas.Tables[0].Rows[0]["Compra"] != DBNull.Value)
                    inversion = (decimal)dsventas.Tables[0].Rows[0]["Compra"];
                if(dsventas.Tables[0].Rows[0]["Venta"] != DBNull.Value)
                    ventas = (decimal)dsventas.Tables[0].Rows[0]["Venta"];
                utilidad = ventas - inversion;
            }
            Document doc_pdf = new Document(PageSize.Letter);
            doc_pdf.SetMargins(85.0394f, 85.0394f, 50.8661f, 70.8661f);
            //BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font arial9Bold = new Font(FontFactory.GetFont("Arial", 9, Font.BOLD));
            Font arial8 = new Font(FontFactory.GetFont("Arial", 9, Font.NORMAL));
            Font TimesNewRomas12SubTitu = new Font(FontFactory.GetFont("Times New Roman", 12, Font.NORMAL));
            TimesNewRomas12SubTitu.SetColor(131, 160, 164);
            Font TimesNewRoman10 = new Font(FontFactory.GetFont("Times New Roman", 12, Font.NORMAL));
            TimesNewRoman10.SetColor(52, 52, 52);
            Font TimesNewRoman10Verde = new Font(FontFactory.GetFont("Times New Roman", 12, Font.NORMAL));
            TimesNewRoman10Verde.SetColor(116, 171, 107);
            Font TimesNewRoman10Rojo = new Font(FontFactory.GetFont("Times New Roman", 12, Font.NORMAL));
            TimesNewRoman10Rojo.SetColor(210, 23, 7);
            Font TimesNewRoman10Title = new Font(FontFactory.GetFont("Times New Roman", 12, Font.BOLD));
            TimesNewRoman10Title.SetColor(0, 128, 213);
            Font TimesNewRoman10Bold = new Font(FontFactory.GetFont("Times New Roman", 12, Font.BOLD));
            TimesNewRoman10Bold.SetColor(52, 52, 52);
            doc_pdf.AddTitle("Reporte General");

            FileStream os = new FileStream("ReporteGeneral.pdf", FileMode.Create);
            using (os) 
            {
                PdfWriter.GetInstance(doc_pdf, os);
                doc_pdf.Open();
                doc_pdf.Add(new Paragraph("REPORTE GENERAL", TimesNewRoman10Title) { Alignment = Element.ALIGN_CENTER });
                var des = Desde.AddDays(1);
                var hast = Hasta;
                doc_pdf.Add(new Paragraph("Desde: " + des.ToString("yyyy'/'MMMM'/'dd") + "\nHasta: " + hast.AddDays(-1).ToString("yyyy'/'MMMM'/'dd"), TimesNewRoman10Bold) { Alignment = Element.ALIGN_LEFT });

                doc_pdf.Add(new Paragraph("", TimesNewRoman10Bold) { Alignment = Element.ALIGN_CENTER });
                doc_pdf.Add(new Chunk("\n"));
                doc_pdf.Add(new Paragraph("VENTAS", TimesNewRoman10Bold) { Alignment = Element.ALIGN_CENTER });

                PdfPTable tablaGenerales = new PdfPTable(3) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaGenerales.SpacingAfter = 70f;
                tablaGenerales.SpacingBefore = 5f;
                tablaGenerales.AddCell(new PdfPCell(new Phrase("INVERSIÓN", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("CAPITAL", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("UTILIDAD", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(inversion.ToString("C2"), TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(ventas.ToString("C2"), TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(utilidad.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });

                doc_pdf.Add(tablaGenerales);

                dsventas = new DataSet();
                dsventas = Business.Reportes.ReporUtilidadGym(Desde, Hasta);
                if (dsventas != null) {
                    if(dsventas.Tables[0].Rows[0]["utilidadVisitas"] != DBNull.Value)
                        visitas = (decimal)dsventas.Tables[0].Rows[0]["utilidadVisitas"];
                    if(dsventas.Tables[0].Rows[0]["utilidadMensu"] != DBNull.Value)
                        mensualidades = (decimal)dsventas.Tables[0].Rows[0]["utilidadMensu"];
                    suma = visitas + mensualidades;
                }
                doc_pdf.Add(new Paragraph("GIMNASIO", TimesNewRoman10Bold) { Alignment = Element.ALIGN_CENTER });
                tablaGenerales = new PdfPTable(2) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaGenerales.SpacingAfter = 50f;
                tablaGenerales.SpacingBefore = 5f;
                tablaGenerales.AddCell(new PdfPCell(new Phrase(" ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("SUBTOTAL", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("VISITAS", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(visitas.ToString("C2"), TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("SOCIOS", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(mensualidades.ToString("C2"), TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("SUBTOTAL: ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 1 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(suma.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 1 });
                doc_pdf.Add(tablaGenerales);

                dsventas = Business.Reportes.ReporUtilidadEgresos(Desde, Hasta);
                if (dsventas != null) {
                    if (dsventas.Tables[0].Rows[0]["Egresos"] != DBNull.Value)
                        egresos = (decimal)dsventas.Tables[0].Rows[0]["Egresos"];
                }
                tablaGenerales = new PdfPTable(2) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaGenerales.SpacingAfter = 60f;
                tablaGenerales.SpacingBefore = 5f;
                tablaGenerales.AddCell(new PdfPCell(new Phrase("EGRESOS: ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 1 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("-" + egresos.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 1 });
                doc_pdf.Add(tablaGenerales);

                tablaGenerales = new PdfPTable(2) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaGenerales.SpacingAfter = 70f;
                tablaGenerales.SpacingBefore = 5f;
                decimal total = (utilidad + visitas + mensualidades) - egresos;
                tablaGenerales.AddCell(new PdfPCell(new Phrase("TOTAL: ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 1 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(total.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 1 });
                doc_pdf.Add(tablaGenerales);
                doc_pdf.Close();
                System.Diagnostics.Process.Start("ReporteGeneral.pdf");
            }
        }
    }
}
