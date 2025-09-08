using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Controllers
{
    internal class UsersController
    {
        public void GetUsers()
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Name"].ToString());
            }

            reader.Close();
            ConexionDataBase.CloseConnection();
        }

    }
}
