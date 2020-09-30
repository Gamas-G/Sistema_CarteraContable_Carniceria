using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CarnesCruz.CarnesCruz.Controlador.Reporte
{
    class ConsultasReporte
    {
        public static DataTable BuscarHistoria(string word)
        {
            string query = string.Format("SELECT clientes.nombreCliente AS CLIENTE, facturas.idNota AS NOTA, facturas.fecha AS FECHA, facturas.totalVenta AS IMPORTE, facturas.abono AS ABONO, facturas.saldo AS SALDO FROM facturas NATURAL JOIN clientes WHERE clientes.nombreCliente LIKE '%" + word + "%' ORDER BY clientes.nombreCliente;");
            MySqlConnection conexion = new MySqlConnection();
            conexion = CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;
        }

        public static void CancelarNota(string idNota)
        {
            string comDelete = "DELETE FROM facturas WHERE idNota = '{0}'";
            string query = string.Format(comDelete, idNota);
            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }

        public static void EditarAbono(int idNota, double abono, string saldo)
        {
            string query = string.Format("UPDATE facturas SET facturas.abono = '{1}', facturas.saldo = '{2}' WHERE facturas.idNota = '{0}';", idNota, abono, saldo);

            MySqlCommand comando = new MySqlCommand(query, CarnesCruz.Controlador.BaseDeDatos.ConexionBaseDeDatos.conectar());
            comando.ExecuteNonQuery();
        }
    }
}
