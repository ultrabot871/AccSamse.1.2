using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccSamse._1._2.Models
{
    public static class ConexionDataBase
    {
        // Cadena de conexión
        private static readonly string cadenaConexion =
              "Data Source=KEXXX\\SQLEXPRESS;" +
              "Initial Catalog=AccSamseDbss.1.2;" +
              "Integrated Security=True";

        // Método global para obtener la conexión (NO la abre)
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
