using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.Controlador
{
    abstract class Procesos
    {

        public static void AbrirMysql()
        {
            ProcessStartInfo printProcessInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = @"\xampp\xampp_start.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
            };

            Process printProcess = new Process();
            printProcess.StartInfo = printProcessInfo;
            printProcess.Start();

            printProcess.WaitForExit();
        }

        public static void CerrarMysql()
        {
            ProcessStartInfo printProcessInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = @"\xampp\xampp_stop.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
            };

            Process printProcess = new Process();
            printProcess.StartInfo = printProcessInfo;
            printProcess.Start();

            printProcess.WaitForExit();
        }
    }
}
