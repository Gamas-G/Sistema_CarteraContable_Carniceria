using System;
using System.Linq;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.ModeloVista.Cliente
{
    public partial class EditarCliente : Form
    {
        CarnesCruz.ModeloVista.Inicio.Inicio ini = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Inicio.Inicio>().FirstOrDefault();

        Cliente cliente = Application.OpenForms.OfType<Cliente>().FirstOrDefault();

        public EditarCliente()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(this.textBoxActCliente, "Ingrese el nuevo nombre del cliente");
            this.msjAyuda.SetToolTip(this.textBoxActDirec, "Ingrese la nueva dirección del cliente");

            textBoxActCliente.MaxLength = 35;
            textBoxActDirec.MaxLength = 55;
        }

        private void btnActualizar_Click(object sender, EventArgs e)//Actualizar los datos del cliente
        {
            if ((labelCliente.Text == textBoxActCliente.Text && labelDireccion.Text == textBoxActDirec.Text) || (textBoxActCliente.Text == "" || textBoxActDirec.Text == "")) { return; } // Si no no se hace ningun cambio o el nombre y dereccion ya existen retorna el evento

            if (!CarnesCruz.Controlador.Cliente.ConsultasCliente.ValidaCliente(textBoxActCliente.Text, textBoxActDirec.Text))
            {
                try
                {
                    CarnesCruz.Controlador.Cliente.ConsultasCliente.ActualizarCliente(textBoxActCliente.Text, textBoxActDirec.Text, labelCliente.Text, labelDireccion.Text);

                    if (cliente != null)
                    {
                        cliente.Cliente_Load(sender, e);

                        cliente.RefrescarFactura(sender, e);

                        labelCliente.Text = textBoxActCliente.Text;
                        labelDireccion.Text = textBoxActDirec.Text;
                        labelTituloEditar.Text = labelCliente.Text;

                        RefrescarReporte(sender, e);

                        DialogResult opc = MessageBox.Show("EL DATO A SIDO MODIFICADO\n¿DESEA SEGUIR EN ESTA VENTANA?", "DATO MODIFICADO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (opc == DialogResult.Yes) { return; }
                        else { this.Close(); }
                    }
                }
                catch (Exception o)
                {
                    MessageBox.Show("OCURRIO UN ERROR AL CERRAR LA VENTANA EDITAR\n" + o.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ESTE CLIENTE YA EXISTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RefrescarReporte(object sender, EventArgs e)//Metodo para refrescar la ventanFactura si esque esta abierto
        {
            CarnesCruz.ModeloVista.Reporte.Reporte reporte = Application.OpenForms.OfType<CarnesCruz.ModeloVista.Reporte.Reporte>().FirstOrDefault();
            if (reporte != null) { reporte.Reporte_Load(sender, e); }

            ini.Inicio_Load(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)//Cierra la ventana de Editar
        {
            this.Close(); //Cierra la ventana de Editar
        }

        private void EditarCliente_Load(object sender, EventArgs e)//Refresca los label y los textBox del Form Editar
        {
            textBoxActCliente.Text = labelCliente.Text;
            textBoxActDirec.Text = labelDireccion.Text;
            labelTituloEditar.Text = labelCliente.Text;
        }
    } 
}
