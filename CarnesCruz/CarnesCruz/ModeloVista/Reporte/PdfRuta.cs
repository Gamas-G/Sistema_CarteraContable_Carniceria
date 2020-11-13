using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.ModeloVista.Reporte
{
    public partial class PdfRuta : Form
    {
        public DataGridView reporte;

        public PdfRuta()
        {
            InitializeComponent();

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS\\REPORTES CARTERA")) { Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS\\REPORTES CARTERA"); }
            labelRutaArchivo.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS\\REPORTES CARTERA";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string rutaCompleta = labelRutaArchivo.Text + @"\" + textBoxNombreArchivo.Text + ".pdf";
            if (textBoxNombreArchivo.Text == "") return;


            if (!File.Exists(rutaCompleta))
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
                if (checkBoxNavegador.Checked)
                {
                    System.Diagnostics.Process.Start(rutaCompleta);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else { 
                    CarnesCruz.ModeloVista.Facturacion.PdfImprimir pdfImprimir = new CarnesCruz.ModeloVista.Facturacion.PdfImprimir();
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
        }

        private bool CrearPdf(string path)
        {
            Document doc = new Document(PageSize.LETTER);//Se crea el documento con un tamaño A4 (tamaño carta)

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create)); // asignamos el nombre de archivo Nota.pdf almacenada en la variable path

                doc.Open();//Abrimos el documento para comenzar a trabajar en el

                CrearNota(doc);

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

        private void CrearNota(Document doc)
        {
            Image image = Image.GetInstance(Path.Combine(Application.StartupPath, @"..\..\CarnesCruz\Imagenes\cabeza.png"));
            image.SetAbsolutePosition(0, 680);
            image.ScalePercent(24f);

            //NOTA
            #region Diseño
            Paragraph titulo = new Paragraph();
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add(new Chunk("SISTEMA CARNICERIA"));

            Paragraph fecha = new Paragraph();
            fecha.Add(new Chunk(DateTime.Now.ToLongDateString()));
            fecha.Alignment = Element.ALIGN_RIGHT;


            Paragraph infNombreFecha = new Paragraph();
            infNombreFecha.Alignment = Element.ALIGN_CENTER;

            PdfPTable table = new PdfPTable(7);
            table.WidthPercentage = 110;
            #endregion


            doc.Add(image);
            doc.Add(fecha);
            doc.Add(titulo);

            infNombreFecha.Add("REPORTE DE CARTERA\n\n\n\n");

            doc.Add(infNombreFecha);

            table.AddCell("CLIENTE");
            table.AddCell("#NOTA");
            table.AddCell("FECHA");
            table.AddCell("IMPORTE");
            table.AddCell("ABONOS");
            table.AddCell("SALDO");
            table.AddCell("RECIBIO");

            foreach (DataGridViewRow row in reporte.Rows)
            {
                table.AddCell(row.Cells[reporte.Columns[0].Name].Value.ToString());
                table.AddCell(row.Cells[reporte.Columns[1].Name].Value.ToString());
                table.AddCell(row.Cells[reporte.Columns[2].Name].Value.ToString());
                table.AddCell(row.Cells[reporte.Columns[3].Name].Value.ToString());
                table.AddCell(row.Cells[reporte.Columns[4].Name].Value.ToString());
                table.AddCell(row.Cells[reporte.Columns[5].Name].Value.ToString());
                table.AddCell("");
            }

            doc.Add(table);
        }
    }
}
