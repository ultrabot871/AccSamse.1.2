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
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "INSERT INTO dbo.Client " +
                    "(name, last_Name, email, document, phone) " +
                    "VALUES (@name, @last, @mail, @doc, @phone)";

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
        }

        // ===== READ ALL =====
        public List<Client> GetAll()
        {
            var list = new List<Client>();
            
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id_Client, name, last_Name, email, document, phone FROM dbo.Client";

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

            return list;
        }

        // ===== READ BY DOCUMENT =====
        public Client GetById(int document)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT id_Client, name, last_Name, email, document, phone " +
                    "FROM dbo.Client WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@doc", document);

                    
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return Map(r);
                        }
                    }
                }
            }
            return null;
        }

        public Client GetByIdWhithDoc(int doc)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT id_Client, name, last_Name, email, " +
                    "document, phone " +
                    "FROM dbo.Client WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@doc", doc);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            // Aquí usamos tu Map y retornamos directamente
                            return Map(r);
                        }
                    }
                }
            }

            // Si no se encuentra ningún usuario
            return null;
        }

        // ===== UPDATE =====
        public bool Update(Client u)
        {
            
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "UPDATE dbo.Client SET " +
                    "name=@name, last_Name=@last, email=@mail, phone=@phone " +
                    "WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", u.Name);
                    cmd.Parameters.AddWithValue("@last", u.Last_Name);
                    cmd.Parameters.AddWithValue("@mail", u.Email);
                    cmd.Parameters.AddWithValue("@phone", (object)u.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@doc", u.Document);

                    
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // ===== DELETE =====
        public bool Delete(int document)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM dbo.Client WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@doc", document);

                    
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // ===== READ BY EMAIL =====
        public Client GetByEmail(string email)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT id_Client, name, last_Name, email, document, phone " +
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
            }
            return null;
        }
    }
}
