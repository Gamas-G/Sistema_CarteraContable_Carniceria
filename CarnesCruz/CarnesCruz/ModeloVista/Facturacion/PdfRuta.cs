using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.ModeloVista.Facturacion
{
    public partial class PdfRuta : Form
    {
        public DataGridView dataCliente1, dataCliente2;

        public string numNota, numNota2;

        public string[] clientes = new string[2];
        public string[] Total = new string[2];

        public PdfRuta()
        {
            InitializeComponent();

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS")) { Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS"); }
            labelRutaArchivo.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS";
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string rutaCompleta = labelRutaArchivo.Text + @"\" + textBoxNombreArchivo.Text + ".pdf";

            if(!File.Exists(rutaCompleta))
            {
                CreacionButtonImprimir(rutaCompleta);
            }
            else
            {
                DialogResult res = MessageBox.Show("EL NOMBRE DEL ARCHIVO YA EXISTE, ¿DESEAS SOBRE ESCRIBIR EL DOCUMENTO?\nPUEDES CAMBIAR EL NOMBRE DEL ARCHIVO ACTUAL", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    CreacionButtonImprimir(rutaCompleta);
                }
            }
        }

        private void CreacionButtonImprimir(string rutaCompleta)
        {
            if (CrearPdf(rutaCompleta))
            {
                //System.Diagnostics.Process.Start(rutaCompleta);
                PdfImprimir pdfImprimir = new PdfImprimir();

                pdfImprimir.labelNombreDelArchivo.Text = textBoxNombreArchivo.Text;
                pdfImprimir.PreViewPdf.src = rutaCompleta + "#toolbar=0";
                pdfImprimir.PreViewPdf.setShowToolbar(false);
                pdfImprimir.rutaArchivo = rutaCompleta;
                pdfImprimir.ControlBox = false;
                if (pdfImprimir.ShowDialog() == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        }

        private bool CrearPdf(string path)
        {
            Document doc = new Document(PageSize.LETTER);//Se crea el documento con un tamaño A4 (tamaño carta)

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create)); // asignamos el nombre de archivo Nota.pdf almacenada en la variable path

                doc.Open();//Abrimos el documento para comenzar a trabajar en el

                CrearNota(doc, clientes[0], Total[0], dataCliente1, numNota);

                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------------------"));

                CrearNota(doc, clientes[1], Total[1], dataCliente2, numNota2);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                doc.Close();
            }
        }

        private void CrearNota(Document doc, string clienteNota, string SumaTotal, DataGridView dataPrecios, string numeroNota)
        {
            //NOTA
            #region Diseño
            Paragraph titulo = new Paragraph();
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add(new Chunk("NOTA"));

            Image image = Image.GetInstance(Path.Combine(Application.StartupPath, @"..\..\CarnesCruz\Imagenes\cabeza.png"));
            image.Alignment = Element.ALIGN_LEFT;
            image.ScalePercent(24f);

            Paragraph infNombreFecha = new Paragraph();
            infNombreFecha.Alignment = Element.ALIGN_RIGHT;

            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
           
            PdfPCell clien = new PdfPCell(new Phrase("CLIENTE: " + clienteNota + "\n\n"));
            clien.HorizontalAlignment = 0;
            clien.Colspan = 5;
            clien.Border = Rectangle.NO_BORDER;

            PdfPCell cellTotal = new PdfPCell(new Phrase("TOTAL:"));
            cellTotal.Colspan = 4;
            cellTotal.HorizontalAlignment = 2;

            Paragraph firmaCliente = new Paragraph("Firma del Cliente:______________________");
            firmaCliente.Alignment = Element.ALIGN_LEFT;
            #endregion


            doc.Add(titulo);

            infNombreFecha.Add("SISTEMA CARNICERIA\n");
            infNombreFecha.Add(DateTime.Now.ToLongDateString());
            infNombreFecha.Add("\nCancún, Quintana Roo\n");
            infNombreFecha.Add("Hora: " + DateTime.Now.ToShortTimeString());
            infNombreFecha.Add("\nNOTA# " + numeroNota);
            infNombreFecha.Add(image);
            doc.Add(infNombreFecha);

            table.AddCell(clien);

            table.AddCell("CANT.");
            table.AddCell("PESO");
            table.AddCell("DESCRIPCION");
            table.AddCell("PRECIO UNIT.");
            table.AddCell("IMPORTE");

            foreach (DataGridViewRow row in dataPrecios.Rows)
            {
                table.AddCell(row.Cells[dataPrecios.Columns[1].Name].Value.ToString());
                table.AddCell(row.Cells[dataPrecios.Columns[2].Name].Value.ToString());
                table.AddCell(row.Cells[dataPrecios.Columns[0].Name].Value.ToString());
                table.AddCell(row.Cells[dataPrecios.Columns[3].Name].Value.ToString());
                table.AddCell(row.Cells[dataPrecios.Columns[5].Name].Value.ToString());
            }

            table.AddCell(cellTotal);
            table.AddCell(SumaTotal);

            doc.Add(table);

            doc.Add(firmaCliente);
        }

        private void btnNombreArchivo_Click(object sender, EventArgs e)
        {
            if (textBoxNombreArchivo.ReadOnly == true)
            {
                textBoxNombreArchivo.ReadOnly = false;
            }
            else
                textBoxNombreArchivo.ReadOnly = true;
        }

        private void textBoxNombreArchivo_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNombreArchivo.Text == "")
            {
                errorProvider1.SetError(textBoxNombreArchivo, "El campo no puede estar vacio");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxNombreArchivo, "");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPathCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            string foldername = "";
            if (result == DialogResult.OK)
            {
                foldername = this.folderBrowserDialog1.SelectedPath;
                labelRutaArchivo.Text = foldername;
            }
        }
    }
}
