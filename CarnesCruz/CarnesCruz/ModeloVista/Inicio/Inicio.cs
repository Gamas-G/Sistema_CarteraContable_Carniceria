using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace CarnesCruz.CarnesCruz.ModeloVista.Inicio
{
    public partial class Inicio : Form
    {
        DataTable deudas;
        public Inicio()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(this.textBoxBuscarCliente, "Ingrese el nombre del cliente");
            this.msjAyuda.SetToolTip(pictureBoxClearCliente, "Elimina todo el contenido escrito");
        }

        public void Inicio_Load(object sender, EventArgs e)
        {
            CargarInicio();
        }

        private void CargarInicio()
        {
            deudas = CarnesCruz.Controlador.Inicio.ConsultasInicio.BuscarProductos(textBoxBuscarCliente.Text);
            dataGridViewConsultaDeudas.DataSource = deudas;

            SumaDeudas();//Metodo para sumar la columna de Dueda del dataGridview en tiempo
        }

        private void SumaDeudas()
        {
            var TotalCantidad = deudas.AsEnumerable().Sum(p => p.Field<double>("DEUDA"));

            labelSumaTotalDeudas.Text = TotalCantidad.ToString();
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarInicio();
        }

        private void pictureBoxClearCliente_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(40, 29);
        }

        private void pictureBoxClearCliente_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(38, 26);
        }

        private void pictureBoxClearCliente_Click(object sender, EventArgs e)
        {
            textBoxBuscarCliente.Clear();
        }
    }
}
