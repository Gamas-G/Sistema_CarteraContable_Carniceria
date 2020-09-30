using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace CarnesCruz.CarnesCruz.ModeloVista.Facturacion
{
    public partial class Pago : Form
    {
        Facturacion facturacion = Application.OpenForms.OfType<Facturacion>().First();//Intancia para refrescar los datos del dataGridview del Inicio

        public Pago()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            facturacion.banderaPago = '0';
            this.Close();
        }

        #region Pago1


        private void checkBoxDeuda_CheckedChanged(object sender, EventArgs e)
        {
            CheckDeuda(checkBoxDeuda, textBoxCantAPagar, labelCambio);
        }

        private void textBoxCantAPagar_KeyPress(object sender, KeyPressEventArgs e)//Evento restringe la escritura de letras y simbolos para evitar errores por parte del usuario y evitar posibles fallas en el programa
        {
            ValidTextBoKeyPress(e);
        }

        private void textBoxCantAPagar_TextChanged(object sender, EventArgs e)//Evento por parte del TextBox, sirve para calcular el cambio del cliente en tiempo
        {
            ValidarTextBoxTextChanged(textBoxCantAPagar, checkBoxDeuda, labelCambio, labelTotalAPagar);
        }

        private void textBoxCantAPagar_Validating(object sender, CancelEventArgs e)//Evento Del textBox, donde realizar multiples validaciones
        {
            ValidarTextBoxValidating(textBoxCantAPagar, labelCambio, labelTotalAPagar, e);
        }
        #endregion


        #region Pago 2


        private void checkBoxDeuda2_CheckedChanged(object sender, EventArgs e)
        {
            CheckDeuda(checkBoxDeuda2, textBoxCantAPagar2, labelCambio2);
        }

        private void textBoxCantAPagar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidTextBoKeyPress(e);
        }

        private void textBoxCantAPagar2_TextChanged(object sender, EventArgs e)
        {
            ValidarTextBoxTextChanged(textBoxCantAPagar2, checkBoxDeuda2, labelCambio2, labelTotalAPagar2);
        }

        private void textBoxCantAPagar2_Validating(object sender, CancelEventArgs e)
        {
            ValidarTextBoxValidating(textBoxCantAPagar2, labelCambio2, labelTotalAPagar2, e);
        }
        #endregion

        #region Eventos de Botones


        private void ButtonPagar_Click(object sender, EventArgs e)
        {
            if (TipoDeudasPago() && TipoDeudasPago2())
                this.Close();
    }
        private bool TipoDeudasPago()
        {
            if (checkBoxDeuda.Checked == true)//El cliente no realizo ningun pago en su compra
            {
                facturacion.banderaPago = '1';
                facturacion.cantPagada = labelTotalAPagar.Text;
                facturacion.abono = "0";
                return true;

            }
            else if (textBoxCantAPagar.Text == "")//Si no hay nada saldra del evento
            {
                return false;
            }
            else if (labelCambio.Text != "0")//Si el valor del cambio cambia y no es 0 significa que el cliente realizo un abono
            {
                facturacion.banderaPago = '2';
                facturacion.cantPagada = labelCambio.Text;
                facturacion.abono = textBoxCantAPagar.Text;
                return true;
            }
            else //Si no es una de las anteriores significa que el cliente pago toda la compra, devolviendo valores para la decision de la base de datos
            {
                facturacion.banderaPago = '3';
                facturacion.cantPagada = "0";
                return true;
            }
        }
        private bool TipoDeudasPago2()
        {
            if (checkBoxDeuda2.Checked == true)//El cliente no realizo ningun pago en su compra
            {
                facturacion.banderaPago2Cliente = '1';
                facturacion.cantPagadacliente2 = labelTotalAPagar2.Text;
                facturacion.abono2 = "0";
                return true;

            }
            else if (textBoxCantAPagar2.Text == "")//Si no hay nada saldra del evento
            {
                return false;
            }
            else if (labelCambio2.Text != "0")//Si el valor del cambio cambia y no es 0 significa que el cliente realizo un abono
            {
                facturacion.banderaPago2Cliente = '2';
                facturacion.cantPagadacliente2 = labelCambio2.Text;
                facturacion.abono2 = textBoxCantAPagar2.Text;
                return true;
            }
            else //Si no es una de las anteriores significa que el cliente pago toda la compra, devolviendo valores para la decision de la base de datos
            {
                facturacion.banderaPago2Cliente = '3';
                facturacion.cantPagadacliente2 = "0";
                return true;
            }
        }

        #endregion

        #region Funciones Genericas Compartidas Entre Pago 1 y 2
        private void ValidarTextBoxValidating(TextBox textBoxCant, Label labCambio, Label labTotalAPagar, CancelEventArgs e)
        {
            if (textBoxCant.Text == "") { labCambio.Text = "0"; errorProvider1.SetError(textBoxCant, ""); return; }//Si no hay ningun valor hace un return y limpia el error (si es que ocurrio uno anteriormente)

            else if (!ValidarMonto(textBoxCant.Text))//Aquí valida si lo ingresado no es un número (error mas común '2....')
            {
                errorProvider1.SetError(textBoxCant, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO Y DECIMAL\n EJEMPLO: '2', '2.5'");//Mostrando un icono con el siguiente mensaje
                e.Cancel = true;//Cancelando la funcion de escribir sobre el textbox y que el usuario realize otra accion hasta corregir dicho error
            }
            else if (((Convert.ToDouble(labTotalAPagar.Text)) - (Convert.ToDouble(textBoxCant.Text))) < 0)//En caso de que el número ingresado es menor a 0 se genera el siguiente mensaje
            {
                errorProvider1.SetError(textBoxCant, "ERROR EL PAGO ES MAYOR AL TOTAL");
                e.Cancel = true;
            }
        }

        private void CheckDeuda(CheckBox check, TextBox textBoxCantidad, Label labelCamb)
        {
            if (check.Checked == true)
            {
                textBoxCantidad.ReadOnly = true;
                textBoxCantidad.Clear();
                labelCamb.Text = "0";
            }
            else
                textBoxCantidad.ReadOnly = false;
        }

        private void ValidTextBoKeyPress(KeyPressEventArgs e)
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

        private void ValidarTextBoxTextChanged(TextBox textBoxCant, CheckBox check, Label labCambio, Label labTotalAPagar)
        {
            if (textBoxCant.Text == "")
            {
                check.Enabled = true;//Si detecta que el textBox no tiene algun valor deja habilitado el checkBox
                labCambio.Text = "0";
            }
            else if (ValidarMonto(textBoxCant.Text))//Si detecta un valor, este valida si lo ingresado es un número real, si es asi...
            {
                check.Enabled = false;//Deshabilita el checkBox y...
                labCambio.Text = ((Convert.ToDouble(labTotalAPagar.Text)) - (Convert.ToDouble(textBoxCant.Text))).ToString();//Realiza el calculo del cambio mostrandolo en tiempo
                errorProvider1.SetError(textBoxCant, "");//Esto es por si previamente detecto un error, este lo limpia si todo esta correcto
            }
        }

        private bool ValidarMonto(string monto)
        {
            double result;

            if (double.TryParse(monto, out result))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
