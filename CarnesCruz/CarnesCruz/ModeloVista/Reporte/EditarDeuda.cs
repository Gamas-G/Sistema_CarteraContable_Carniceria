using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnesCruz.CarnesCruz.ModeloVista.Reporte
{
    public partial class EditarDeuda : Form
    {
        public int idNota;
        public double importeTotal;

        public EditarDeuda()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCantAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTeclado(e);
        }
        private void ValidarTeclado(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxCantAPagar_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCantAPagar.Text == "") { labelCambio.Text = "0"; errorProvider1.SetError(textBoxCantAPagar, ""); return; }//Si no hay ningun valor hace un return y limpia el error (si es que ocurrio uno anteriormente)

            else if (!ValidarMonto(textBoxCantAPagar.Text))//Aquí valida si lo ingresado no es un número (error mas común '2....')
            {
                errorProvider1.SetError(textBoxCantAPagar, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO O DECIMAL\n EJEMPLO: '2', '2.50'");//Mostrando un icono con el siguiente mensaje
                e.Cancel = true;//Cancelando la funcion de escribir sobre el textbox y que el usuario realize otra accion hasta corregir dicho error
            }
            else if (((Convert.ToDouble(labelTotalDeuda.Text)) - (Convert.ToDouble(textBoxCantAPagar.Text))) < 0)//En caso de que el número ingresado es menor a 0 se genera el siguiente mensaje
            {
                errorProvider1.SetError(textBoxCantAPagar, "ERROR EL PAGO ES MAYOR AL TOTAL");
                e.Cancel = true;
            }
        }

        private void textBoxCantAPagar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCantAPagar.Text == "")
                labelCambio.Text = "0";

            else if (ValidarMonto(textBoxCantAPagar.Text))//Si detecta un valor, este valida si lo ingresado es un número real, si es asi...
            {
                labelCambio.Text = (Math.Round(((Convert.ToDouble(labelTotalDeuda.Text)) - (Convert.ToDouble(textBoxCantAPagar.Text))), 2)).ToString();//Realiza el calculo del cambio mostrandolo en tiempo
                errorProvider1.SetError(textBoxCantAPagar, "");//Esto es por si previamente detecto un error, este lo limpia si todo esta correcto
            }
        }

        private bool ValidarMonto(string monto)
        {
            if (double.TryParse(monto, out double result))
            {
                return true;
            }
            return false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PagarAbono(sender, e);
        }

        private void PagarAbono(object sender, EventArgs e)
        {
            if (textBoxCantAPagar.Text == "")
                return;

            try
            {
                if (labelCambio.Text == "0")
                {
                    CarnesCruz.Controlador.Reporte.ConsultasReporte.CancelarNota(idNota.ToString());
                    this.Close();
                }
                else
                {
                    double abon = importeTotal - Convert.ToDouble(labelCambio.Text);

                    CarnesCruz.Controlador.Reporte.ConsultasReporte.EditarAbono(idNota, abon, labelCambio.Text);
                }

                Refrescar(sender, e);
                labelTotalDeuda.Text = labelCambio.Text;
                textBoxCantAPagar.Clear();

                DialogResult opc = MessageBox.Show("EL ABONO A SIDO INGRESADO\n¿DESEA SEGUIR EN ESTA VENTANA?", "ABONO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (opc == DialogResult.Yes) { return; }
                else { this.Close(); }
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
        }

        public void Refrescar(object sender, EventArgs e)//Metodo para refrescar la ventanFactura si esque esta abierto
        {
            CarnesCruz.ModeloVista.Reporte.Reporte resporte = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Reporte.Reporte>().FirstOrDefault();
            if (resporte != null) { resporte.RefrescarInicio(sender, e); }
        }
    }
}
