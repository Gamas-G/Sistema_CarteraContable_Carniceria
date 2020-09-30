using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CarnesCruz.CarnesCruz.Controlador.Producto
{
    class ConsultasProducto
    {
        public static DataTable BuscarProductos(string word)
        {
            string query = string.Format("SELECT idProducto AS ID, nombreProducto AS Producto, precioProducto AS 'Precio (KG)' from productos WHERE nombreProducto LIKE '%" + word + "%';");
            MySqlConnection conexion = new MySqlConnection();
            conexion = CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;

        }

        public static void AgregarProducto(string nombreProducto, string precioProducto)
        {
            string comAgregar = "INSERT INTO productos (nombreProducto, precioProducto) VALUES ('{0}', '{1}');";
            string query = string.Format(comAgregar, nombreProducto, precioProducto);
            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static bool ValidarProducto(string nombrProducto, string precioProducto)
        {
            string cmd = "SELECT * FROM productos WHERE nombreProducto = '{0}' AND precioProducto = '{1}';";
            string query = String.Format(cmd, nombrProducto, precioProducto);

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

        public static void ActualizarProducto(string nuevoNombreProducto, string nuevoPrecioProducto, string nombreProducto, string precioProducto)
        {
            string comUpdate = "UPDATE productos SET nombreProducto = '{0}', precioProducto = '{1}' WHERE nombreProducto = '{2}' AND precioProducto = '{3}';";
            string query = string.Format(comUpdate, nuevoNombreProducto, nuevoPrecioProducto, nombreProducto, precioProducto);
            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static void EliminarProducto(int idProducto)
        {
            string comDelete = "DELETE FROM productos WHERE idProducto = '{0}'";
            string query = string.Format(comDelete, idProducto);
            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }
    }
}
