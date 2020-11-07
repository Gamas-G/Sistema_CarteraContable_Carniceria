using CarnesCruz.CarnesCruz.Controlador;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace CarnesCruz
{
    public partial class Form1 : Form
    {

        const int alto = 758;

        private Panel bordeBotones;
        private Button currentBtn;

        
        public Form1()
        {
            InitializeComponent();

            this.msjAyuda.SetToolTip(this.pictureBoxInicio, "INICIO");//Mensaje de ayuda
            bordeBotones = new Panel
            {
                Size = new Size(7, 62)
            };
            panelContBotns.Controls.Add(bordeBotones);//Agregando al panel de botones un borde
            
        }

        private void ActivarBotones(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;//Casteo
                currentBtn.BackColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borde Izquierdo del Button
                bordeBotones.BackColor = Color.FromArgb(0,80,200);
                bordeBotones.Location = new Point(0, currentBtn.Location.Y);
                bordeBotones.Visible = true;
                bordeBotones.BringToFront();
            }

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.Control;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                bordeBotones.Visible = false;
            }
        }


        private void OpenForms<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivarBotones(sender);
            OpenForms<CarnesCruz.ModeloVista.Cliente.Cliente>();
            Redimencionar(sender);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivarBotones(sender);
            OpenForms<CarnesCruz.ModeloVista.Productos.Productos>();
            Redimencionar(sender);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivarBotones(sender);
            OpenForms<CarnesCruz.ModeloVista.Reporte.Reporte>();
            Redimencionar(sender);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ActivarBotones(sender);
            OpenForms<CarnesCruz.ModeloVista.Facturacion.Facturacion>();
            Redimencionar(sender);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            OpenForms<CarnesCruz.ModeloVista.Inicio.Inicio>();
        }

        private void pictureBoxInicio_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenForms<CarnesCruz.ModeloVista.Inicio.Inicio>();
            Redimencionar(sender);
        }

        public void Redimencionar(object bottn)
        {
            if (bottn == btnReporte || bottn == btnProductos || bottn == btnCliente || bottn == pictureBoxInicio)
            {
                if (this.Height != alto)
                {
                    this.Size = new Size(this.Width, 758);
                    this.Location = new Point(this.Location.X, ((Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2));
                }
            }
            else
            {
                this.Location = new Point(this.Location.X, 0);
                this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var processExists = Process.GetProcesses().Any(p => p.ProcessName.Contains("mysqld"));

            //if (processExists) Procesos.CerrarMysql();
        }
    }
}
