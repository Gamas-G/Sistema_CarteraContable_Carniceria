using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

namespace CarnesCruz.CarnesCruz.ModeloVista.Reporte
{
    public partial class Reporte : Form
    {
        
        PdfRuta pdfRuta;

        public Reporte()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(this.textBoxBuscarCliente, "Ingrese el nombre del cliente");
            this.msjAyuda.SetToolTip(pictureBoxClearCliente, "Elimina todo el contenido escrito");
        }

        public void Reporte_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridViewHistoriaCompras.DataSource = CarnesCruz.Controlador.Reporte.ConsultasReporte.BuscarHistoria(textBoxBuscarCliente.Text);
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnCancelarNota_Click(object sender, EventArgs e)
        {
            CancelarNota(sender, e);
        }

        private void CancelarNota(object sender, EventArgs e)
        {
            if (dataGridViewHistoriaCompras.RowCount == 0) return;
            string nota = dataGridViewHistoriaCompras.SelectedCells[1].EditedFormattedValue.ToString();
            string nombreNota = dataGridViewHistoriaCompras.SelectedCells[0].EditedFormattedValue.ToString();
            DialogResult opc = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR LA NOTA: '" + nota + "'\n A NOMBRE DEL CLIENTE: '" + nombreNota + "'?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opc == DialogResult.Yes)
            {
                try
                {
                    CarnesCruz.Controlador.Reporte.ConsultasReporte.CancelarNota(nota);

                    RefrescarInicio(sender, e);

                    MessageBox.Show("SE A CANCELADO LA NOTA: '" + nota + "'\n" +"A NOMBRE DEL CLIENTE: " + nombreNota , "NOTA CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception o)
                {

                    MessageBox.Show("OCURRIO UN ERROR AL ELIMINAR EL CLIENTE\n" + o.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RefrescarInicio(object sender, EventArgs e)//Metodo para refrescar la ventanFactura si esque esta abierto
        {
            CarnesCruz.ModeloVista.Inicio.Inicio inicio = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Inicio.Inicio>().FirstOrDefault();
            if (inicio != null) { inicio.Inicio_Load(sender, e); }

            CargarDatos();
        }

        private void pictureBoxClearCliente_Click(object sender, EventArgs e)
        {
            textBoxBuscarCliente.Clear();
        }

        private void pictureBoxClearCliente_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxClearCliente.Size = new Size(40, 29);
        }

        private void pictureBoxClearCliente_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(38, 26);
        }

        private void btnAbonarDeuda_Click(object sender, EventArgs e)
        {
            AbonarDeuda();
        }

        private void AbonarDeuda()
        {
            if (dataGridViewHistoriaCompras.RowCount == 0) return;

            CarnesCruz.ModeloVista.Reporte.EditarDeuda editarDeuda = new CarnesCruz.ModeloVista.Reporte.EditarDeuda();

            editarDeuda.labelCliente.Text = dataGridViewHistoriaCompras.SelectedCells[0].EditedFormattedValue.ToString();
            editarDeuda.labelTotalDeuda.Text = dataGridViewHistoriaCompras.SelectedCells[5].EditedFormattedValue.ToString();
            editarDeuda.idNota = Convert.ToInt16(dataGridViewHistoriaCompras.SelectedCells[1].EditedFormattedValue.ToString());
            editarDeuda.importeTotal = Convert.ToDouble(dataGridViewHistoriaCompras.SelectedCells[3].EditedFormattedValue.ToString());
            editarDeuda.ControlBox = false;
            editarDeuda.ShowDialog();
        }

        private void ButtonGenerarReporte_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistoriaCompras.Rows.Count == 0) return;

            if (pdfRuta == null)
            {
                pdfRuta = new PdfRuta();
                pdfRuta.ControlBox = false;

                pdfRuta.reporte = dataGridViewHistoriaCompras;
                pdfRuta.textBoxNombreArchivo.Text = "REPORTE__" + textBoxBuscarCliente.Text + "__" + DateTime.Now.ToLongDateString();

                pdfRuta.FormClosed += new FormClosedEventHandler(Cerrar_pdfRuta);
                pdfRuta.ShowDialog();
            }
        }

        public void Cerrar_pdfRuta(object sender, EventArgs e)
        {
            pdfRuta = null;
        }

        private void dataGridViewHistoriaCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbonarDeuda();
        }
    }
}
