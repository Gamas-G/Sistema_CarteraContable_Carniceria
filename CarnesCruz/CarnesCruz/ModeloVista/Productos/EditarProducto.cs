using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.ModeloVista.Productos
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(textBoxActProducto, "Ingrese el nuevo nombre del producto");
            this.msjAyuda.SetToolTip(textBoxActPrecio, "Ingrese el nuevo precio del producto");
            textBoxActProducto.MaxLength = 35;
            textBoxActPrecio.MaxLength = 8;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ((labelProducto.Text == textBoxActProducto.Text && labelPresioProducto.Text == textBoxActPrecio.Text) || (textBoxActProducto.Text == "" || textBoxActPrecio.Text == "")) { return; }

            string precio = Math.Round(Convert.ToDouble(textBoxActPrecio.Text), 2).ToString();

            if (!CarnesCruz.Controlador.Producto.ConsultasProducto.ValidarProducto(textBoxActProducto.Text, precio))
            {
                try
                {
                    CarnesCruz.Controlador.Producto.ConsultasProducto.ActualizarProducto(textBoxActProducto.Text, precio, labelProducto.Text, labelPresioProducto.Text);

                    Productos producto = Application.OpenForms.OfType<Productos>().FirstOrDefault();
                    if (producto != null)
                    {
                        producto.Productos_Load(sender, e);

                        producto.RefrescarFactura(sender, e);

                        labelProducto.Text = textBoxActProducto.Text;
                        labelPresioProducto.Text = textBoxActPrecio.Text;
                        labelTituloEditar.Text = labelProducto.Text;

                        DialogResult opc = MessageBox.Show("EL DATO A SIDO MODIFICADO\n¿DESEA SEGUIR EN ESTA VENTANA?", "DATO MODIFICADO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (opc == DialogResult.Yes) { return; }
                        else { this.Close(); }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("OCURRIO UN ERROR\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ESTE PRODUCTO YA EXISTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            labelTituloEditar.Text = labelProducto.Text;

            textBoxActProducto.Text = labelProducto.Text;
            textBoxActPrecio.Text = labelPresioProducto.Text;
        }

        private void textBoxActPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxActPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxActPrecio.Text == "") { errorProvider1.SetError(textBoxActPrecio, ""); return; }

            if (!double.TryParse(textBoxActPrecio.Text, out double result))
            {
                errorProvider1.SetError(textBoxActPrecio, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO O DECIMAL\n EJEMPLO: '2', '2.5'");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxActPrecio, "");
        }
    }
}
