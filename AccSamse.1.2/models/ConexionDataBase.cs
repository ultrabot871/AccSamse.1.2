using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccSamse._1._2.Models
{
    public static class ConexionDataBase
    {
        // 🔹 Conexión estática global
        private static SqlConnection _conexion;

        // 🔹 Cadena de conexión (puedes moverla a App.config después)
        private static readonly string cadenaConexion =
            "Data Source=SANTIAGO\\SANTIAGO;Initial Catalog=TiendaDB;Integrated Security=True";

        // 🔹 Método global para obtener la conexión
        public static SqlConnection GetConnection()
        {
            if (_conexion == null)
            {
                _conexion = new SqlConnection(cadenaConexion);
                System.Windows.Forms.MessageBox.Show("conexion exitosa");

            }


            if (_conexion.State == System.Data.ConnectionState.Closed)
            {
                _conexion.Open();
                
            }
                

            return _conexion;
        }

        // 🔹 Método global para cerrar conexión
        public static void CloseConnection()
        {
            if (_conexion != null && _conexion.State == System.Data.ConnectionState.Open)
                _conexion.Close();
        }
    }
}
