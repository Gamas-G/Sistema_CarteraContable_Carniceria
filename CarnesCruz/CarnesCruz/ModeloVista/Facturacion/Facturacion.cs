using System;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using System.IO;


namespace CarnesCruz.CarnesCruz.ModeloVista.Facturacion
{
    public partial class Facturacion : Form
    {
        #region Variables
        string numNota, numNota2;

        double valorVenta, valorVenta2, valorpeso, valorPeso2, valorVentaGridView;

        int verif = 0;

        public string abono, abono2;

        public string cantPagada = "";
        public char banderaPago = '0';

        public string cantPagadacliente2 = "";
        public char banderaPago2Cliente = '0';

        DataTable TablaClientes, TablaClientes2, TablaProductos, TablaProductos2;

        Pago pago;

        Form1 ini = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        #endregion

        public Facturacion()
        {
            InitializeComponent();
            this.msjAyuda.SetToolTip(this.textBoxVenta, "Escriba la venta\nImportante el sistema toma hasta 2 decimales, esto puede redondear");
            this.msjAyuda.SetToolTip(this.textBoxVenta2, "Escriba la venta\nImportante el sistema toma hasta 2 decimales, esto puede redondear");
        }

        public void Facturacion_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void Carga()
        {
            numNota = CarnesCruz.Controlador.Facturacion.ConsultasFacturacion.GetLastId();
            numNota2 = (Convert.ToInt64(numNota) + 1).ToString();


            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxProductos.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxClientes2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes2.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxProductos2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxProductos2.AutoCompleteSource = AutoCompleteSource.ListItems;

            TablaProductos = CarnesCruz.Controlador.Facturacion.ConsultasFacturacion.buscarProductosFacturacion();
            TablaClientes = CarnesCruz.Controlador.Facturacion.ConsultasFacturacion.buscarClientesFacturacion();

            TablaProductos2 = CarnesCruz.Controlador.Facturacion.ConsultasFacturacion.buscarProductosFacturacion();
            TablaClientes2 = CarnesCruz.Controlador.Facturacion.ConsultasFacturacion.buscarClientesFacturacion();

            comboBoxClientes.ValueMember = "nombreCliente";
            comboBoxClientes.DataSource = TablaClientes;

            comboBoxProductos.ValueMember = "nombreProducto";
            comboBoxProductos.DataSource = TablaProductos;

            comboBoxClientes2.ValueMember = "nombreCliente";
            comboBoxClientes2.DataSource = TablaClientes2;

            comboBoxProductos2.ValueMember = "nombreProducto";
            comboBoxProductos2.DataSource = TablaProductos2;
        }



        #region Nota1

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.Text == "" || comboBoxProductos.Text == "" || textBoxVenta.Text == "" || textBoxPeso.Text == "") { return; }

            var (PrecioBase, TotalVenta) = GetPrecioTotal(TablaProductos, comboBoxProductos.Text, valorpeso, valorVenta);

            dataGridViewFatura.Rows.Add(comboBoxProductos.Text, textBoxVenta.Text, (Convert.ToDouble(textBoxPeso.Text) * valorVenta).ToString(), PrecioBase, DateTime.Now.ToLongDateString(), TotalVenta, textBoxPeso.Text);

        }

        #region Eventos del DataGridViewFactura
        private void dataGridViewFatura_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidarDataGridViewCellValidating(dataGridViewFatura, e, labelTotalFactura);
        }

        private void dataGridViewFatura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SumaTotal(dataGridViewFatura, labelTotalFactura);
        }

        private void dataGridViewFatura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SumaTotal(dataGridViewFatura, labelTotalFactura);
        }

        private void dataGridViewFatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTeclado(e);
        }

        private void dataGridViewFatura_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl tb)
            {
                tb.KeyPress -= dataGridViewFatura_KeyPress;
                tb.KeyPress += dataGridViewFatura_KeyPress;
            }
        }
        #endregion

        #region Eventos TextBoxVenta y TextBox Peso
        private void textBoxVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTeclado(e);
        }

        private void textBoxVenta_Validating(object sender, CancelEventArgs e)
        {
            VentaValidating(textBoxVenta, e);
        }

        private void textBoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTecladoPeso(e);
        }

        private void textBoxPeso_Validating(object sender, CancelEventArgs e)
        {
            PesoValidating(textBoxPeso, e);
        }
        #endregion

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFacturaClienteNombre.Text = comboBoxClientes.Text;
        }

        #endregion

        #region Metodos para TextBoxVenta y TextBoxPeso (NOTA 1)

        private void VentaValidating(TextBox TextBoxVentas, CancelEventArgs e)//Evento que valida en los eventos Validating de TextBoxVenta 1 y 2
        {
            if (TextBoxVentas.Text == "") { errorProvider1.SetError(TextBoxVentas, ""); return; }
            if (!ValidarVenta(TextBoxVentas.Text))
            {
                errorProvider1.SetError(TextBoxVentas, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO, DECIMAL O FRACCIÓN\n EJEMPLO: '2', '2.5', '1/4'");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(TextBoxVentas, "");
        }

        private bool ValidarVenta(string valor)
        {
            if (valor.Contains('/'))
            {
                if (ConvertNumero(valor) > 0)
                {
                    return true;
                }
        }
            else if (double.TryParse(valor, out double result))
            {
                valorVenta = result;
                return true;
            }
            return false;
        }

        private double ConvertNumero(string vent)
        {
            try
            {
                string[] aux;
                double resultado;
                aux = vent.Split(new char[] { '/' }, 2);
                resultado = (double.Parse(aux[0]) / double.Parse(aux[1]));

                valorVenta = Math.Round(resultado, 2);
                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void PesoValidating(TextBox TextBoxPesos, CancelEventArgs e)//Evento que valida en los eventos Validating de TextBoxVenta 1 y 2
        {
            if (TextBoxPesos.Text == "") { errorProvider1.SetError(TextBoxPesos, ""); return; }
            if (!ValidarPeso(TextBoxPesos.Text))
            {
                errorProvider1.SetError(TextBoxPesos, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO O DECIMAL\n EJEMPLO: '2', '2.5'");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(TextBoxPesos, "");
        }

        private bool ValidarPeso(string valor)
        {
            if (double.TryParse(valor, out double result))
            {
                valorpeso = result;
                return true;
            }
            return false;
        }

        #endregion




        #region Nota 2

        private void buttonAgregarProducto2_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes2.Text == "" || comboBoxProductos2.Text == "" || textBoxVenta2.Text == "") { return; }

            var (PrecioBase, TotalVenta) = GetPrecioTotal(TablaProductos, comboBoxProductos2.Text, valorPeso2 ,valorVenta2);

            dataGridViewFactura2.Rows.Add(comboBoxProductos2.Text, textBoxVenta2.Text, (Convert.ToDouble(textBoxPeso2.Text) * valorVenta2).ToString(), PrecioBase, DateTime.Now.ToLongDateString(), TotalVenta, textBoxPeso2.Text);
        }

        #region Eventos del DataGridViewFactura2
        private void dataGridViewFactura2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidarDataGridViewCellValidating(dataGridViewFactura2, e, labelTotalFactura2);
        }

        private void dataGridViewFactura2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SumaTotal(dataGridViewFactura2, labelTotalFactura2);
        }

        private void dataGridViewFactura2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SumaTotal(dataGridViewFactura2, labelTotalFactura2);
        }

        private void dataGridViewFactura2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl tb)
            {
                tb.KeyPress -= dataGridViewFactura2_KeyPress;
                tb.KeyPress += dataGridViewFactura2_KeyPress;
            }
        }

        private void dataGridViewFactura2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTeclado(e);
        }

        #endregion

        #region Eventos TextBoxVenta2 y TextBoxPeso
        private void textBoxVenta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTeclado(e);
        }

        private void textBoxVenta2_Validating(object sender, CancelEventArgs e)
        {
            VentaValidating2(textBoxVenta2, e);
        }

        private void textBoxPeso2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTecladoPeso(e);
        }

        private void textBoxPeso2_Validating(object sender, CancelEventArgs e)
        {
            PesoValidating2(textBoxPeso2, e);
        }

        #endregion


        private void comboBoxClientes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFacturuaClienteNombre2.Text = comboBoxClientes2.Text;
        }

        #endregion

        #region Metodos para TextBoxVenta2 y TextBoxPeso2 (NOTA 2)

        private void VentaValidating2(TextBox TextBoxVentas, CancelEventArgs e)//Evento que valida en los eventos Validating de TextBoxVenta 1 y 2
        {
            if (TextBoxVentas.Text == "") { errorProvider1.SetError(TextBoxVentas, ""); return; }
            if (!ValidarVenta2(TextBoxVentas.Text))
            {
                errorProvider1.SetError(TextBoxVentas, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO, DECIMAL O FRACCIÓN\n EJEMPLO: '2', '2.5', '1/4'");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(TextBoxVentas, "");
        }

        private bool ValidarVenta2(string valor)
        {
            if (valor.Contains('/'))
            {
                if(ConvertNumero2(valor) > 0)
                    return true;
            }
            else if (double.TryParse(valor, out double result))
            {
                valorVenta2 = result;
                return true;
            }
            return false;
        }

        private double ConvertNumero2(string vent)
        {
            try
            {
                string[] aux;
                double resultado;
                aux = vent.Split(new char[] { '/' }, 2);
                resultado = (double.Parse(aux[0]) / double.Parse(aux[1]));

                valorVenta2 = Math.Round(resultado, 2);
                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void PesoValidating2(TextBox TextBoxPesos, CancelEventArgs e)//Evento que valida en los eventos Validating de TextBoxVenta 1 y 2
        {
            if (TextBoxPesos.Text == "") { errorProvider1.SetError(TextBoxPesos, ""); return; }
            if (!ValidarPeso2(TextBoxPesos.Text))
            {
                errorProvider1.SetError(TextBoxPesos, "ERROR AL INGRESAR EL VALOR\nEL VALOR PUEDE SER UN ENTERO O DECIMAL\n EJEMPLO: '2', '2.5'");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(TextBoxPesos, "");
        }

        private bool ValidarPeso2(string valor)
        {
            if (double.TryParse(valor, out double result))
            {
                valorPeso2 = result;
                return true;
            }
            return false;
        }

        #endregion




        #region Funciones Compartidas de Nota 1 y Nota 2

        private (string PrecioBase, string TotalVenta) GetPrecioTotal(DataTable tablasProductos, string producto, double peso, double venta)
        {
            DataRow[] findPrice;

            findPrice = tablasProductos.Select("nombreProducto = '" + producto + "'");
            string PrecioBase = findPrice[0][2].ToString();
            string TotalVenta = GetTotal(PrecioBase.ToString(), peso, venta);


            return (PrecioBase, TotalVenta);
        }

        private string GetTotal(string precio, double peso, double venta)
        {
            double calculo = 0;

            double num2 = Convert.ToDouble(precio);
            calculo = num2 * peso * venta;

            return calculo.ToString();
        }

        private void ValidarDataGridViewCellValidating(DataGridView dataGridView, DataGridViewCellValidatingEventArgs e, Label labelTotalNotas)
        {
            if (verif != 0) { return; }

            try
            {
                if (ValidarVentaGridView(dataGridView.SelectedCells[1].EditedFormattedValue.ToString()) && (double.TryParse(dataGridView.SelectedCells[3].EditedFormattedValue.ToString(), out double convrtNumero)))
                {
                    dataGridView.Rows[e.RowIndex].ErrorText = "";
                    double precioBase = Math.Round(Convert.ToDouble(dataGridView.SelectedCells[3].EditedFormattedValue.ToString()), 2);

                    valorVentaGridView = Math.Round((valorVentaGridView * Convert.ToDouble(dataGridView.SelectedCells[6].EditedFormattedValue.ToString())), 2);

                    double calculo = Math.Round((valorVentaGridView * precioBase), 2);

                    dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[2].Value = valorVentaGridView.ToString();
                    dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[5].Value = calculo.ToString();

                    SumaTotal(dataGridView, labelTotalNotas);

                }
                else
                {
                    dataGridView.Rows[e.RowIndex].ErrorText = "Error en el Precio del producto\nEl campo solo acepta enteros o decimales\nEjemplo: '2', '2.2'";
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " que pedo PEDOOO");
            }
        }

        private void SumaTotal(DataGridView dataGridView, Label totalNota)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                total += Convert.ToDouble(row.Cells[dataGridView.Columns[5].Name].Value);
            }
            totalNota.Text = Convert.ToString(total);
        }

        private void ValidarTeclado(KeyPressEventArgs e)//Evento que valida la entrada de números para el TextBoxVenta 1 y 2
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '/' || e.KeyChar == '.')
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

        private void ValidarTecladoPeso(KeyPressEventArgs e)//Evento que valida la entrada de números para el TextBoxVenta 1 y 2
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

        #region Metodos para el dataGridView y la suma de totales al momento de hacer un cambio de precio
        private bool ValidarVentaGridView(string valor)
        {
            if (valor.Contains('/'))
            {
                if (convertNumeroGridView(valor) > 0)
                {
                    return true;
                }
            }
            else if (double.TryParse(valor, out double result))
            {
                valorVentaGridView = result;
                return true;
            }
            return false;
        }

        private double convertNumeroGridView(string vent)
        {
            try
            {
                string[] aux;
                double resultado;
                aux = vent.Split(new char[] { '/' }, 2);
                resultado = double.Parse(aux[0]) / double.Parse(aux[1]);

                valorVentaGridView = Math.Round(resultado, 2);
                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

        #endregion


        #region Boton Generar Nota
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFatura.Rows.Count == 0 || dataGridViewFactura2.Rows.Count == 0) return;

            if (pago == null)
            {
                pago = new Pago();

                pago.labelNombreCLiente1.Text = labelFacturaClienteNombre.Text;
                pago.labelTotalAPagar.Text = labelTotalFactura.Text;

                pago.labelNombreCliente2.Text = labelFacturuaClienteNombre2.Text;
                pago.labelTotalAPagar2.Text = labelTotalFactura2.Text;

                pago.FormClosed += new FormClosedEventHandler(Realizar_Pago);
                pago.ControlBox = false;
                pago.ShowDialog();
            }

            if (banderaPago == '0') return;

            //MessageBox.Show("hey");

            if (!GenerarNota()) return;

            DeudasClientes(sender, e);
        }

        public void Realizar_Pago(object sender, EventArgs e)
        {
            pago = null;
        }

        private bool GenerarNota()
        {
            string nombreArchivo = labelFacturaClienteNombre.Text + "__" + labelFacturuaClienteNombre2.Text + "__" + DateTime.Now.ToLongDateString();


            CarnesCruz.ModeloVista.Facturacion.PdfRuta pdfRuta = new PdfRuta();
            pdfRuta.ControlBox = false;

            pdfRuta.numNota = numNota;
            pdfRuta.numNota2 = numNota2;

            pdfRuta.clientes[0] = labelFacturaClienteNombre.Text;
            pdfRuta.clientes[1] = labelFacturuaClienteNombre2.Text;

            pdfRuta.textBoxNombreArchivo.Text = nombreArchivo;

            pdfRuta.dataCliente1 = dataGridViewFatura;
            pdfRuta.dataCliente2 = dataGridViewFactura2;

            pdfRuta.Total[0] = labelTotalFactura.Text;
            pdfRuta.Total[1] = labelTotalFactura2.Text;

            if (pdfRuta.ShowDialog() == DialogResult.Cancel) { return false; }
            return true;
        }

        private void DeudasClientes(object sender, EventArgs e)
        {
            if (banderaPago == '1')
            {
                RegistrarNota(labelTotalFactura.Text, labelFacturaClienteNombre.Text, abono, cantPagada);

            }
            else if (banderaPago == '2')
            {
                RegistrarNota(labelTotalFactura.Text, labelFacturaClienteNombre.Text, abono, cantPagada);
            }

            if (banderaPago2Cliente == '1')
            {
                RegistrarNota(labelTotalFactura2.Text, labelFacturuaClienteNombre2.Text, abono2, cantPagadacliente2);
            }
            else if (banderaPago2Cliente == '2')
            {
                RegistrarNota(labelTotalFactura2.Text, labelFacturuaClienteNombre2.Text, abono2, cantPagadacliente2);
            }

            RefrescarHistorial(sender, e);
            RefrescarInicio(sender, e);
            Limpiar();
            Facturacion_Load(sender, e);
        }

        private int GetIdCliente(string labFacturaClienteNombre)
        {
            DataRow[] findId;
            findId = TablaClientes.Select("nombreCliente = '" + labFacturaClienteNombre + "'");
            int resp = Convert.ToInt16(findId[0][0]);
            return resp;
        }

        private void Limpiar()
        {
            verif = 1;
            dataGridViewFatura.Rows.Clear();
            dataGridViewFactura2.Rows.Clear();

            textBoxVenta.Clear();
            textBoxVenta2.Clear();
            verif = 0;
        }

        private void RefrescarInicio(object sender, EventArgs e)//Metodo para refrescar la ventanFactura si esque esta abierto
        {
            CarnesCruz.ModeloVista.Inicio.Inicio inicio = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Inicio.Inicio>().FirstOrDefault();
            if (inicio != null) { inicio.Inicio_Load(sender, e); }
        }

        private void RegistrarNota(string total, string nombCliente, string abono, string saldo)
        {
            try
            {
                CarnesCruz.Controlador.Facturacion.ConsultasFacturacion.InsertarFactura(GetIdCliente(nombCliente), DateTime.Now.ToLongDateString(), total, abono, saldo);
            }
            catch (Exception o)
            {
                MessageBox.Show("OCURRIO UN ERROR AL REGISTRAR LA NOTA \n" + o.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetIdProducto(string nombreProducto)
        {
            DataRow[] findId;
            findId = TablaProductos.Select("nombreProducto = '" + nombreProducto + "'");
            string resp = findId[0][0].ToString();
            return resp;
        }

        private void RefrescarHistorial(object sender, EventArgs e)
        {
            CarnesCruz.ModeloVista.Reporte.Reporte reporte = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Reporte.Reporte>().FirstOrDefault();
            if (reporte != null)
                reporte.Reporte_Load(sender, e);
        }
        #endregion
    }
}
