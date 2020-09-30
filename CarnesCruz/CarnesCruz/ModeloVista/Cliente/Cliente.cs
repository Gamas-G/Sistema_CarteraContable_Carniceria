using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace CarnesCruz.CarnesCruz.ModeloVista.Cliente
{
    public partial class Cliente : Form
    {
        //INSTANCIA PARA LA VENTA EDITAR CLIENTE
        EditarCliente EditarCliente;
        //Variable usada para el evento eliminar
        string clienteEliminado = null;

        public Cliente()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(this.textBoxCliente, "Ingrese el nombre del cliente o dirección");
            this.msjAyuda.SetToolTip(this.pictureBoxAddUser, "Agregar un nuevo cliente");
            this.msjAyuda.SetToolTip(this.textBoxNameUser, "Ingrese el nombre del cliente");
            this.msjAyuda.SetToolTip(this.textBoxAdressUser, "Ingrese la dirección del cliente");
            this.msjAyuda.SetToolTip(pictureBoxClearCliente, "Elimina todo el contenido escrito");

            textBoxNameUser.MaxLength = 35;
            textBoxAdressUser.MaxLength = 55;
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            if ((textBoxNameUser.Text == "" || textBoxAdressUser.Text == "") || (CarnesCruz.Controlador.Cliente.ConsultasCliente.ValidaCliente(textBoxNameUser.Text, textBoxAdressUser.Text))) { return; }
            try
            {
                CarnesCruz.Controlador.Cliente.ConsultasCliente.AgregarUsuario(textBoxNameUser.Text, textBoxAdressUser.Text);
                Cliente_Load(sender, e);

                RefrescarFactura(sender, e);

                MessageBox.Show("EL CLIENTE '"+ textBoxNameUser.Text + "' SE A AGREGADO", "CLIENTE AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNameUser.Clear();
                textBoxAdressUser.Clear();
            }
            catch (Exception o)
            {
                MessageBox.Show("OCURRIO UN ERROR AL MOMENTO DE INGRESAR AL CLIENTE\n" + o.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefrescarFactura(object sender, EventArgs e)//Metodo para refrescar la ventanFactura si esque esta abierto
        {
            CarnesCruz.ModeloVista.Facturacion.Facturacion factura = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Facturacion.Facturacion>().FirstOrDefault();
            if (factura != null) { factura.Facturacion_Load(sender, e); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.RowCount == 0) return;
            clienteEliminado = dataGridViewClientes.SelectedCells[1].EditedFormattedValue.ToString();
            int id = int.Parse(dataGridViewClientes.SelectedCells[0].EditedFormattedValue.ToString());

            DialogResult opc = MessageBox.Show("¿SEGURO QUE DESEA ELIMINAR EL CLIENTE: '" + clienteEliminado +"'?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opc == DialogResult.Yes)
            {
                try
                {
                    if (CarnesCruz.Controlador.Cliente.ConsultasCliente.VerificarClienteDeuda( id )) { MessageBox.Show("ESTE CLIENTE NO PUEDE SER ELIMINADO\nPORQUE SE ENCUENTRA EN LISTA DE DEUDORES", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                    CarnesCruz.Controlador.Cliente.ConsultasCliente.EliminarCliente( id );
                    Cliente_Load(sender, e);

                    RefrescarFactura(sender, e);

                    MessageBox.Show("SE A ELIMINADO EL CLIENTE: '" + clienteEliminado + "'", "CLIENTE ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception o)
                {

                    MessageBox.Show("OCURRIO UN ERROR AL ELIMINAR EL CLIENTE\n" + o.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            clienteEliminado = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.RowCount == 0) return;

                EditarCliente = new EditarCliente();
                EditarCliente.ControlBox = false;

                EditarCliente.labelCliente.Text = dataGridViewClientes.SelectedCells[1].EditedFormattedValue.ToString();
                EditarCliente.labelDireccion.Text = dataGridViewClientes.SelectedCells[2].EditedFormattedValue.ToString();

                EditarCliente.ShowDialog();
        }

        #region Eventos Pequeños

        public void Cliente_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = CarnesCruz.Controlador.Cliente.ConsultasCliente.buscarTabla(textBoxCliente.Text);
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            Cliente_Load(sender, e);
        }

        private void pictureBoxClearCliente_Click(object sender, EventArgs e)
        {
            textBoxCliente.Clear();
        }

        private void pictureBoxClearCliente_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(40, 29);
        }

        private void pictureBoxClearCliente_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClearCliente.Size = new Size(38, 26);
        }

        private void pictureBoxAddUser_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAddUser.Size = new Size(70, 60);
        }

        private void pictureBoxAddUser_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAddUser.Size = new Size(61, 46);
        }

        private void pictureBoxAddUser_Click(object sender, EventArgs e)
        {
            if (panelAgregarCliente.Visible == true)
            {
                panelAgregarCliente.Visible = false;
            }
            else
            {
                panelAgregarCliente.Visible = true;
            }
        }

        private void btnCancelarUser_Click(object sender, EventArgs e)
        {
            panelAgregarCliente.Visible = false;
        }
        #endregion

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }
    }
}
