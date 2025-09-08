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
        // ===== Helpers =====
        private static string ToStr(object value)
        {
            return (value == null || value is DBNull) ? "" : value.ToString();
        }

        private static User Map(SqlDataReader r)
        {
            User u = new User();
            u.Id_person = Convert.ToInt32(r["id_person"]);
            u.Name = ToStr(r["name"]);
            u.Last_Name = ToStr(r["last_Name"]);
            u.Email = ToStr(r["email"]);
            u.Document = ToStr(r["document"]);
            u.Phone = ToStr(r["phone"]);
            u.Role = ToStr(r["role"]);
            u.Password = ToStr(r["password"]);
            u.State = ToStr(r["state"]);
            return u;
        }

        // ===== CREATE =====
        public bool Create(User u)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();
            try
            {
                string sql =
                    "INSERT INTO dbo.usuarios " +
                    "(name, last_Name, email, document, " +
                    "phone, role, [password], [state]) " +
                    "VALUES (@name, @last, @mail, @doc, " +
                    "@phone, @role, @pwd, @state)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", u.Name);
                    cmd.Parameters.AddWithValue("@last", u.Last_Name);
                    cmd.Parameters.AddWithValue("@mail", u.Email);
                    cmd.Parameters.AddWithValue("@doc", u.Document);
                    cmd.Parameters.AddWithValue("@phone", (object)u.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@role", u.Role);
                    cmd.Parameters.AddWithValue("@pwd", u.Password); 
                    cmd.Parameters.AddWithValue("@state", u.State);

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
        public List<User> GetAll()
        {
            List<User> list = new List<User>();
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, role, [password], [state] " +
                    "FROM dbo.usuarios";

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
        public User GetById(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_person, name, last_Name, " +
                    "email, document, phone, role, [password], [state] " +
                    "FROM dbo.usuarios WHERE document=@doc";

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
        public bool Update(User u)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "UPDATE dbo.usuarios SET " +
                    "name=@name, last_Name=@last, email=@mail, document=@doc, " +
                    "phone=@phone, role=@role, [password]=@pwd, [state]=@state " +
                    "WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", u.Id_person);
                    cmd.Parameters.AddWithValue("@name", u.Name);
                    cmd.Parameters.AddWithValue("@last", u.Last_Name);
                    cmd.Parameters.AddWithValue("@mail", u.Email);
                    cmd.Parameters.AddWithValue("@doc", u.Document);
                    cmd.Parameters.AddWithValue("@phone", (object)u.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@role", u.Role);
                    cmd.Parameters.AddWithValue("@pwd", u.Password);
                    cmd.Parameters.AddWithValue("@state", u.State);

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
                string sql = "DELETE FROM dbo.usuarios WHERE document=@doc";

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
        public User GetByEmail(string email)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, role, [password], [state] " +
                    "FROM dbo.usuarios WHERE email=@mail";

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
