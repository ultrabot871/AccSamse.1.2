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
            return new User
            {
                Id_person = Convert.ToInt32(r["id_person"]),
                Name = ToStr(r["name"]),
                Last_Name = ToStr(r["last_Name"]),
                Email = ToStr(r["email"]),
                Document = ToStr(r["document"]),
                Phone = ToStr(r["phone"]),
                Role = ToStr(r["role"]),
                Password = ToStr(r["password"]),
                State = ToStr(r["state"])
            };
        }

        // ===== CREATE =====
        public bool Create(User u)
        {
            string roleLower = u.Role.ToLower();

            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                // Verificamos si ya existe un admin o administrador
                if (roleLower == "admin" || roleLower == "administrador")
                {
                    string checkSql = "SELECT COUNT(*) FROM dbo.usuarios WHERE LOWER(role) = @role";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@role", roleLower);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            return false; // ya existe un admin
                        }
                    }
                }

                string sql =
                    "INSERT INTO dbo.usuarios " +
                    "(name, last_Name, email, document, phone, role, [password], [state]) " +
                    "VALUES (@name, @last, @mail, @doc, @phone, @role, @pwd, @state)";

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
        }

        // ===== READ ALL =====
        public List<User> GetAll()
        {
            var list = new List<User>();

            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, role, [password], [state] " +
                    "FROM dbo.usuarios";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(Map(r));
                    }
                }
            }

            return list;
        }

        // ===== READ BY ID (ojo: usas document, no id_person) =====
        public User GetById(int id)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, role, [password], [state] " +
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
            }

            return null;
        }

        public User GetByIdWhithDoc(int doc)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, role, [password], [state] " +
                    "FROM dbo.usuarios WHERE document=@doc";

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
        public bool Update(User u)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql =
                    "UPDATE dbo.usuarios SET " +
                    "name=@name, last_Name=@last, email=@mail, document=@doc, " +
                    "phone=@phone, role=@role, [password]=@pwd, [state]=@state " +
                    "WHERE document=@doc";

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
        }

        // ===== DELETE =====
        public bool Delete(int id)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM dbo.usuarios WHERE document=@doc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@doc", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // ===== READ BY EMAIL =====
        public User GetByEmail(string email)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
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
            }

            return null;
        }

        // ===== LOGIN =====
        public User Login(string email, string password)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open(); // 👈 NECESARIO ABRIR LA CONEXIÓN

                string sql =
                    "SELECT id_person, name, last_Name, email, " +
                    "document, phone, role, [password], [state] " +
                    "FROM dbo.usuarios WHERE email=@mail AND [password]=@pwd";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@pwd", password);

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
