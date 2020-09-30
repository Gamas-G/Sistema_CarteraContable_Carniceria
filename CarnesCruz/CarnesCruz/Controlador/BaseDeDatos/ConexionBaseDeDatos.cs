using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace CarnesCruz.CarnesCruz.Controlador.BaseDeDatos
{
    class ConexionBaseDeDatos
    {
        public static MySqlConnection conectar()
        {
            string servidor = "127.0.0.1";
            string BD = "bdCarniceria";
            string usuario = "root";
            string password = "";
            MySqlConnection conexion = new MySqlConnection("server=" + servidor + "; database=" + BD + ";Uid=" + usuario + "; pwd=" + password + ";");
            try
            {
            conexion.Open();

            return conexion;
            }
            catch (System.Exception)
            {
                try
                {
                    Procesos.AbrirMysql();
                    MessageBox.Show("La base de datos se desconecto pero se restauro la conexión");
                }
                catch (System.Exception)
                {
                    MessageBox.Show("No se pudo restablecer la conexión a la Base de Datos");
                }
                return conexion;
            }

        }
    }
}
