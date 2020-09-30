using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace CarnesCruz.CarnesCruz.ModeloVista.Facturacion
{
    public partial class PdfImprimir : Form
    {
        public PdfImprimir()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
        }

        public string rutaArchivo;

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            /*NOTA: Una disculpa si no imprime, no tengo impresora para hacer mi prueba :'v deje 3 posible soluciones
             Espero te guste el programa :v
             */
            try
            {
                using (PrintDialog Dialog = new PrintDialog())
                {
                    DialogResult res =  Dialog.ShowDialog();
                    if(res == DialogResult.OK)
                    {
                        ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                        {
                            Verb = "print",
                            CreateNoWindow = true,
                            FileName = rutaArchivo,
                            WindowStyle = ProcessWindowStyle.Hidden,
                        };

                        Process printProcess = new Process();
                        printProcess.StartInfo = printProcessInfo;
                        printProcess.Start();

                        printProcess.WaitForExit();
                        //printProcess.Kill();
                        //printProcess.WaitForInputIdle();

                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception o)
            {
                MessageBox.Show("OCURRIO UN ERROR EN LA IMPRESION\n" + o.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
