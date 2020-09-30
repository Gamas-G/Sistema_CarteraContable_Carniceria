using System.Data;
using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CarnesCruz.CarnesCruz.Controlador.Inicio
{
    class ConsultasInicio
    {
        public static DataTable BuscarProductos(string word)
        {
            string query = string.Format("SELECT clientes.nombreCliente AS CLIENTE, SUM(facturas.saldo) AS DEUDA FROM facturas NATURAL JOIN clientes WHERE clientes.nombreCliente LIKE '%" + word + "%' GROUP by clientes.nombreCliente;");
            MySqlConnection conexion = new MySqlConnection();
            conexion = CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;
        }
    }
}
