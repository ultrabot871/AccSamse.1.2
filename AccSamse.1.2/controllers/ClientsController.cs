using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccSamse._1._2.Models;
using System.Data.SqlClient;



namespace AccSamse._1._2.Controllers
{
    internal class ClientsController
    {
        // ===== Helpers =====
        private static string ToStr(object value)
        {
            return (value == null || value is DBNull) ? "" : value.ToString();
        }

        private static Client Map(SqlDataReader r)
        {
            Client u = new Client();
            u.Id_person = Convert.ToInt32(r["id_Client"]);
            u.Name = ToStr(r["name"]);
            u.Last_Name = ToStr(r["last_Name"]);
            u.Email = ToStr(r["email"]);
            u.Document = ToStr(r["document"]);
            u.Phone = ToStr(r["phone"]);
            return u;
        }

        // ===== CREATE =====
        public bool Create(Client u)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();
            try
            {
                string sql =
                    "INSERT INTO dbo.Client " +
                    "(name, last_Name, email, document, " +
                    "phone) " +
                    "VALUES (@name, @last, @mail, @doc, " +
                    "@phone)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", u.Name);
                    cmd.Parameters.AddWithValue("@last", u.Last_Name);
                    cmd.Parameters.AddWithValue("@mail", u.Email);
                    cmd.Parameters.AddWithValue("@doc", u.Document);
                    cmd.Parameters.AddWithValue("@phone", (object)u.Phone ?? DBNull.Value);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // ===== READ ALL =====
        public List<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_Client, name, last_Name, email, " +
                    "document, phone " +
                    "FROM dbo.Client";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(Map(r));
                        }
                    }
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }

            return list;
        }

        // ===== READ BY ID =====
        public Client GetById(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_Client, name, last_Name, " +
                    "email, document, phone " +
                    "FROM dbo.Client WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@doc", id);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return Map(r);
                        }
                    }
                }
                return null;
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // ===== UPDATE =====
        public bool Update(Client u)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "UPDATE dbo.Client SET " +
                    "name=@name, last_Name=@last, email=@mail, document=@doc, " +
                    "phone=@phone " +
                    "WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", u.Id_person);
                    cmd.Parameters.AddWithValue("@name", u.Name);
                    cmd.Parameters.AddWithValue("@last", u.Last_Name);
                    cmd.Parameters.AddWithValue("@mail", u.Email);
                    cmd.Parameters.AddWithValue("@doc", u.Document);
                    cmd.Parameters.AddWithValue("@phone", (object)u.Phone ?? DBNull.Value);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // ===== DELETE =====
        public bool Delete(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = "DELETE FROM dbo.Client WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@doc", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // ===== READ BY EMAIL =====
        public Client GetByEmail(string email)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, typeClient " +
                    "FROM dbo.Client WHERE email=@mail";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mail", email);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return Map(r);
                        }
                    }
                }
                return null;
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }
    }
}
