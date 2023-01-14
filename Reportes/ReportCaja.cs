using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System_Titanium.Business;
using System.Windows.Forms;

namespace System_Titanium.Reportes
{
    class ReportCaja
    {
        public void PrintReporteCaja(int id, string nombre, decimal montoContado, decimal montoCalcu, decimal diferencia, decimal retirado, DateTime fecha, int IDCorteAnter, decimal montoCaja) {
            decimal retiros = 0;
            decimal ingresoVisita = 0;
            decimal ingresoMensu = 0;
            decimal ingresoVentas = 0;
            int filas = 0;
            DataSet ingresosTemporales = new DataSet();
            try
            {
                ingresosTemporales = CrudCaja.VerCortesXfecha(id, IDCorteAnter);
                if (ingresosTemporales.Tables[0].Rows[0]["Visitas"] != DBNull.Value)
                    ingresoVisita = (decimal)ingresosTemporales.Tables[0].Rows[0]["Visitas"];
                if (ingresosTemporales.Tables[0].Rows[0]["Mensualidades"] != DBNull.Value)
                    ingresoMensu = (decimal)ingresosTemporales.Tables[0].Rows[0]["Mensualidades"];
                if (ingresosTemporales.Tables[0].Rows[0]["ventas"] != DBNull.Value)
                    ingresoVentas = (decimal)ingresosTemporales.Tables[0].Rows[0]["ventas"];
                if (ingresosTemporales.Tables[0].Rows[0]["Retiros"] != DBNull.Value)
                {
                    retiros = (decimal)ingresosTemporales.Tables[0].Rows[0]["Retiros"];
                }
            }
            catch {
                MessageBox.Show("Ocurrió Un Error al consultar las ganancias, intentelo de nuevo. ");
            }

            DataSet dsEgresos = new DataSet();
            dsEgresos = CrudCaja.VerEGRESOS(id, IDCorteAnter);
            if (dsEgresos != null) {
                filas = dsEgresos.Tables.Count;
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
            TimesNewRoman10Title.SetColor(0,128,213);
            Font TimesNewRoman10Bold = new Font(FontFactory.GetFont("Times New Roman", 12, Font.BOLD));
            TimesNewRoman10Bold.SetColor(52, 52, 52);
            doc_pdf.AddTitle("Reporte de Caja");

            FileStream os = new FileStream("Caja.pdf", FileMode.Create);

            using (os) {
                PdfWriter.GetInstance(doc_pdf,os);
                doc_pdf.Open();

                //Image imgEncabezado = Image.GetInstance(Properties.Resources._1345472,System.Drawing.Imaging.ImageFormat.Png);
                //imgEncabezado.Width = 0;
                //imgEncabezado.Alignment = Element.ALIGN_LEFT;
                //float porcentaje = 120 / imgEncabezado.Width;
                //imgEncabezado.ScalePercent(porcentaje * 100);

                //doc_pdf.Add(imgEncabezado);

                // INICIA INFORME DE CORTE DE CAJA
                //doc_pdf.Add(new Paragraph("Usuario: " + "Nombre ", TimesNewRoman10) { Alignment = Element.ALIGN_RIGHT });
                doc_pdf.Add(new Paragraph("CORTE DE CAJA", TimesNewRoman10Title) { Alignment = Element.ALIGN_CENTER });

                

                PdfPTable tableIngresos = new PdfPTable(1) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER }; //Se crea la tabla
                
                tableIngresos.SpacingBefore = 20f;
                tableIngresos.SpacingAfter = 10f;

                PdfPCell celdasIngresos = new PdfPCell();
                var celdasIngresos1 = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255)};
                //celdasIngresos.BorderColorRight = new BaseColor(255,255,255);
                //celdasIngresos.BorderColorLeft = new BaseColor(255, 255, 255);
                celdasIngresos1.Colspan = 1;

                Paragraph parrafo = new Paragraph();
                Phrase oracion = new Phrase();
                oracion = new Phrase("Fecha y Hora de Corte: ", TimesNewRoman10Bold);
                parrafo.Add(oracion);
                oracion = new Phrase(fecha+"\n", TimesNewRoman10);
                parrafo.Add(oracion);
                oracion = new Phrase("Usuario: ", TimesNewRoman10Bold);
                parrafo.Add(oracion);
                oracion = new Phrase(nombre, TimesNewRoman10);
                parrafo.Add(oracion);

                celdasIngresos1.AddElement(parrafo);
                tableIngresos.AddCell(celdasIngresos1);

                doc_pdf.Add(tableIngresos);

                PdfPTable tablaGenerales = new PdfPTable(2) { WidthPercentage = 55f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaGenerales.SpacingAfter = 30f;
                tablaGenerales.SpacingBefore = 10f;
                tablaGenerales.AddCell(new PdfPCell(new Phrase("Calculado.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(montoCalcu.ToString("C2"), TimesNewRoman10Verde)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("Contado.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(montoContado.ToString("C2"), TimesNewRoman10Verde)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("Diferencia.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(diferencia.ToString("C2"), TimesNewRoman10Rojo)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaGenerales.AddCell(new PdfPCell(new Phrase("Retiro por Corte.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaGenerales.AddCell(new PdfPCell(new Phrase(retirado.ToString("C2"), TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                doc_pdf.Add(tablaGenerales);

                doc_pdf.Add(new Paragraph("Ingresos", TimesNewRomas12SubTitu) { Alignment = Element.ALIGN_CENTER });

                PdfPTable tablaIngresos = new PdfPTable(2) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER }; //Se crea la tabla;
                tablaIngresos.SpacingBefore = 10f;
                tablaIngresos.SpacingAfter = 30f;
                PdfPCell celdIngresos = new PdfPCell();
                celdasIngresos.Colspan = 2;

                decimal subTot = ingresoMensu + ingresoVentas + ingresoVisita + montoCaja;
                tablaIngresos.AddCell(new PdfPCell(new Phrase("Ventas.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingresoVentas.ToString("C2"), TimesNewRoman10Verde)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaIngresos.AddCell(new PdfPCell(new Phrase("Visitas.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingresoVisita.ToString("C2"), TimesNewRoman10Verde)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) }); 
                tablaIngresos.AddCell(new PdfPCell(new Phrase("Mensualidades.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingresoMensu.ToString("C2"), TimesNewRoman10Verde)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaIngresos.AddCell(new PdfPCell(new Phrase("Caja.", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaIngresos.AddCell(new PdfPCell(new Phrase(montoCaja.ToString("C2"), TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaIngresos.AddCell(new PdfPCell(new Phrase("SUBTOTAL", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaIngresos.AddCell(new PdfPCell(new Phrase(subTot.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });

                
                doc_pdf.Add(tablaIngresos);

                doc_pdf.Add(new Paragraph("Egresos", TimesNewRomas12SubTitu) { Alignment = Element.ALIGN_CENTER });

                PdfPTable tablaEgresos = new PdfPTable(3) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaEgresos.SpacingAfter = 30f;
                tablaEgresos.SpacingBefore = 10f;
                celdasIngresos.Colspan = 2;
                tablaEgresos.AddCell(new PdfPCell(new Phrase("Usuario", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                tablaEgresos.AddCell(new PdfPCell(new Phrase("Concepto", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) }) ;
                tablaEgresos.AddCell(new PdfPCell(new Phrase("Cantidad", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BackgroundColor = new BaseColor(238, 249, 249) });
                //Se agrega dinamicamente los egresos
                decimal suma = 0;
                for (int i = 0; i < filas; i++) {
                    DateTime fech = (DateTime)dsEgresos.Tables[0].Rows[i]["fechaHoraMov"];
                    string concepto = (string)dsEgresos.Tables[0].Rows[i]["concepto"];
                    decimal cantidad = (decimal)dsEgresos.Tables[0].Rows[i]["cantRetiro"];
                    string usuario = (string)dsEgresos.Tables[0].Rows[i]["uUserName"];
                    tablaEgresos.AddCell(new PdfPCell(new Phrase(fech.ToString()+"\n"+ usuario, TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0, BorderWidthBottom = 1, BorderColor = new BaseColor(170, 171, 171) });
                    tablaEgresos.AddCell(new PdfPCell(new Phrase(concepto, TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0, BorderWidthBottom = 1, BorderColor = new BaseColor(170, 171, 171) });
                    tablaEgresos.AddCell(new PdfPCell(new Phrase(cantidad.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BorderWidthBottom = 1, BorderColor = new BaseColor(170, 171, 171) });
                    suma = suma + cantidad;
                }
                tablaEgresos.AddCell(new PdfPCell(new Phrase(" ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaEgresos.AddCell(new PdfPCell(new Phrase("SUBTOTAL", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaEgresos.AddCell(new PdfPCell(new Phrase(suma.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });

                doc_pdf.Add(tablaEgresos);

                tablaEgresos = new PdfPTable(2) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER };
                tablaEgresos.SpacingAfter = 10f;
                tablaEgresos.SpacingBefore = 10f;
                tablaEgresos.AddCell(new PdfPCell(new Phrase("TOTAL.", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                tablaEgresos.AddCell(new PdfPCell(new Phrase(montoCalcu.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0, BorderWidthBottom = 1, BorderColor = new BaseColor(170, 171, 171) }) ;
                doc_pdf.Add(tablaEgresos);
                doc_pdf.Close();
                System.Diagnostics.Process.Start("Caja.pdf");
            }
        }
    }
}
