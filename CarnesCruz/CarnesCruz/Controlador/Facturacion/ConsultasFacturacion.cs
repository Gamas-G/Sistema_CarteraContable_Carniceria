using System;
using System.Data;
using MySql.Data.MySqlClient;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.Controlador.Facturacion
{
    class ConsultasFacturacion
    {

        public static DataTable buscarClientesFacturacion()
        {
            //string query = string.Format("SELECT idCliente, nombreCliente from clientes WHERE nombreCliente LIKE '%" + word + "%';");
            string query = string.Format("SELECT idCliente, nombreCliente from clientes");

            MySqlConnection conexion = new MySqlConnection();
            conexion = CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;

        }

        public static DataTable buscarProductosFacturacion()
        {
            string query = string.Format("SELECT * FROM productos");

            MySqlConnection conexion = new MySqlConnection();
            conexion = CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;

        }

        public static void ValidaDeuda(int Cliente, string deuda)
        {
            string cmd = "SELECT * FROM deudas WHERE idCliente = '{0}';";
            string query = String.Format(cmd, Cliente);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            int respuesta = Convert.ToInt32(comando.ExecuteScalar());

            if (respuesta == 0)
            {
                InsertarDeuda(Cliente, deuda);
            }
            else
            {
                ActualizarDeuda(Cliente, deuda);
            }
        }

        private static void InsertarDeuda(int idCliente, string deuda)
        {
            string query = string.Format("INSERT INTO deudas (idCliente, Deuda) values('{0}', '{1}');", idCliente, deuda);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        private static void ActualizarDeuda(int idCliente, string deudaNueva)
        {
            string query = string.Format("UPDATE deudas SET deudas.Deuda = deudas.Deuda + '{1}' WHERE deudas.idCliente = '{0}';", idCliente, deudaNueva);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static void InsertarFactura(int idCliente, string fecha, string totalVenta, string abono, string saldo)
        {
            string query = string.Format("INSERT INTO facturas (idCliente, fecha, totalVenta, abono, saldo) values('{0}', '{1}', '{2}', '{3}', '{4}');", idCliente, fecha, totalVenta, abono, saldo);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static string GetLastId()
        {
            string cmd = "SELECT MAX(facturas.idNota) FROM facturas;";
            string query = String.Format(cmd);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            string respuesta = Convert.ToString(comando.ExecuteScalar());
            string res = (respuesta.Equals("")) ? "1" : (Convert.ToInt16(respuesta) + 1).ToString();
            return res;
        }
    }
}
