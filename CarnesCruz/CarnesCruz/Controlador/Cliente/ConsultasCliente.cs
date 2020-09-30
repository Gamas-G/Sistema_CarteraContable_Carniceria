using System;
using System.Data;
using MySql.Data.MySqlClient;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.Controlador.Cliente
{
    class ConsultasCliente
    {

        public static void AgregarUsuario(string nombCliente, string dircCliente)
        {
            string query = string.Format("INSERT INTO clientes (nombreCliente, direcCliente) values('{0}','{1}');", nombCliente, dircCliente);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static DataTable buscarTabla(string word)
        {

            string query = string.Format("SELECT idCliente AS 'ID', nombreCliente AS 'Nombre', direcCliente AS 'Direccion' from clientes WHERE nombreCliente LIKE '%" + word + "%' OR direcCliente LIKE '%" + word + "%';");

            MySqlConnection conexion = new MySqlConnection();
            conexion = CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;

        }

        public static void ActualizarCliente(string actCliente, string actDirec, string nombrCliente, string dircCliente)
        {
            string comUpdate = "UPDATE clientes SET nombreCliente = '{0}', direcCliente = '{1}' WHERE nombreCliente = '{2}' AND direcCliente = '{3}';";
            string query = string.Format(comUpdate, actCliente, actDirec, nombrCliente, dircCliente);
            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static void EliminarCliente(int idCliente)
        {
            string comDelete = "DELETE FROM clientes WHERE idCliente = '{0}'";
            string query = string.Format(comDelete, idCliente);
            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static bool ValidaCliente(string validCliente, string validDireccion)
        {
            string cmd = "SELECT * FROM clientes WHERE nombreCliente = '{0}' AND direcCliente = '{1}';";
            string query = String.Format(cmd, validCliente, validDireccion);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            int respuesta = Convert.ToInt32(comando.ExecuteScalar());

            if (respuesta == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool VerificarClienteDeuda(int idCliente)
        {
            string cmd = "SELECT * FROM facturas WHERE idCliente = '{0}';";
            string query = String.Format(cmd, idCliente);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            int respuesta = Convert.ToInt32(comando.ExecuteScalar());

            if (respuesta == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
