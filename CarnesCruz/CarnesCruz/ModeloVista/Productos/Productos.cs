using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace CarnesCruz.CarnesCruz.ModeloVista.Productos
{
    public partial class Productos : Form
    {
        //Intancia de la ventana EditarProducto
        EditarProducto EditarProducto;
        //ImprimirPraftica ImprimirPraftica;

        string productoEliminado = null;

        //Constructor por defecto
        public Productos()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(textBoxProducto,"Escriba el nombre del producto");
            this.msjAyuda.SetToolTip(pictureBoxAddProducto,"Ingresar nuevo producto");
            this.msjAyuda.SetToolTip(textBoxNombreProducto,"Ingrese el nombre del producto");
            this.msjAyuda.SetToolTip(textBoxPrecioProducto,"Ingreso el precio del producto");
            this.msjAyuda.SetToolTip(pictureBoxClearCliente, "Elimina todo el contenido escrito");

            textBoxNombreProducto.MaxLength = 35;
            textBoxPrecioProducto.MaxLength = 8;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if ((textBoxNombreProducto.Text == "" || textBoxPrecioProducto.Text == "") || (CarnesCruz.Controlador.Producto.ConsultasProducto.ValidarProducto(textBoxNombreProducto.Text, Math.Round(Convert.ToDouble(textBoxPrecioProducto.Text), 2).ToString()))) { return; }

            try
            {
                CarnesCruz.Controlador.Producto.ConsultasProducto.AgregarProducto(textBoxNombreProducto.Text, Math.Round(Convert.ToDouble(textBoxPrecioProducto.Text), 2).ToString());

                Productos_Load(sender, e);

                RefrescarFactura(sender, e);

                MessageBox.Show("EL PRODUCTO '" + textBoxNombreProducto.Text + "' SE A GUARDADO", "PRODUCTO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNombreProducto.Clear();
                textBoxPrecioProducto.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("OCURRIO UN ERROR AL AGREGAR UN CLIENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefrescarFactura(object sender, EventArgs e)//Metodo para refrescar la ventanFactura si esque esta abierto
        {
            CarnesCruz.ModeloVista.Facturacion.Facturacion factura = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Facturacion.Facturacion>().FirstOrDefault();
            if (factura != null) { factura.Facturacion_Load(sender, e); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.RowCount == 0) return;

            DialogResult opc = MessageBox.Show("¿SEGURO QUE DESEA ELIMINAR EL PRODUCTO: '" + dataGridViewProductos.SelectedCells[1].EditedFormattedValue.ToString() + "'?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opc == DialogResult.Yes)
            {
                if(EditarProducto != null) { EditarProducto.Close(); }

                try
                {
                    productoEliminado = dataGridViewProductos.SelectedCells[1].EditedFormattedValue.ToString();
                    CarnesCruz.Controlador.Producto.ConsultasProducto.EliminarProducto(int.Parse(dataGridViewProductos.SelectedCells[0].EditedFormattedValue.ToString()));
                    Productos_Load(sender, e);

                    RefrescarFactura(sender, e);

                    MessageBox.Show("SE A ELIMINADO EL PRODUCTO: '" + productoEliminado + "'", "PRODUCTO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("A OCURRIO UN ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            productoEliminado = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.RowCount == 0) return;

                EditarProducto = new EditarProducto();
                EditarProducto.ControlBox = false;

                EditarProducto.labelProducto.Text = dataGridViewProductos.SelectedCells[1].EditedFormattedValue.ToString();
                EditarProducto.labelPresioProducto.Text = dataGridViewProductos.SelectedCells[2].EditedFormattedValue.ToString();

                EditarProducto.ShowDialog();
        }

        private void textBoxPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxPrecioProducto_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrecioProducto.Text == "") { errorProvider1.SetError(textBoxPrecioProducto, ""); return; }

            if (!double.TryParse(textBoxPrecioProducto.Text, out double result))
            {
                errorProvider1.SetError(textBoxPrecioProducto, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO O DECIMAL\n EJEMPLO: '2', '2.5'");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxPrecioProducto, "");
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar_Click(sender, e);
        }

        #region Eventos Pequeños

        public void Productos_Load(object sender, EventArgs e)
        {
            dataGridViewProductos.DataSource = CarnesCruz.Controlador.Producto.ConsultasProducto.BuscarProductos(textBoxProducto.Text);
        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {
            Productos_Load(sender, e);
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            panelAgregarProductos.Visible = false;
        }

        private void pictureBoxAddProducto_Click(object sender, EventArgs e)
        {
            if (panelAgregarProductos.Visible == true)
            {
                panelAgregarProductos.Visible = false;
            }
            else
            {
                panelAgregarProductos.Visible = true;
            }
        }

        private void pictureBoxAddProducto_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAddProducto.Size = new Size(70, 60);
        }

        private void pictureBoxAddProducto_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAddProducto.Size = new Size(61, 46);
        }

        private void pictureBoxClearCliente_Click(object sender, EventArgs e)
        {
            textBoxProducto.Clear();
        }

        private void pictureBoxClearCliente_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(40, 29);
        }

        private void pictureBoxClearCliente_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(38, 26);
        }

        #endregion
    }
}
