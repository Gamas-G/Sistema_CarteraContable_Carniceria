using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using CarnesCruz.CarnesCruz.Controlador;

namespace CarnesCruz
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Mutex mtex = new Mutex(true, "CarnesCruz", out bool instanceCountOne))
            {
                if (instanceCountOne && VerificarDB())
                {
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS\\REPORTES CARTERA")) { Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NOTAS\\REPORTES CARTERA"); }
                    Application.Run(new Form1());
                    mtex.ReleaseMutex();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private static bool VerificarDB()
        {
            try
            {
                var processExists = Process.GetProcesses().Any(p => p.ProcessName.Contains("mysqld"));

                if (!processExists) Procesos.AbrirMysql();
                
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error en la conexión a la base de datos\n" +
                                "Si no cuenta con MySQL puede descargar el siguiente programa en el siguiente enlace: \n" +
                                "https://www.apachefriends.org/es/index.html");
                return false;

            }
        }
    }
}
