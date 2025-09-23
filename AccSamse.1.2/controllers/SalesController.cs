using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Controllers
{
    internal class SalesController
    {
        private static string ToStr(object value)
        {
            return (value == null || value is DBNull) ? "" : value.ToString();
        }

        private static Sale Map(SqlDataReader r)
        {
            Sale s = new Sale();
            s.Id_Sale = Convert.ToInt32(r["id_Sale"]);
            s.Id_Person = Convert.ToInt32(r["id_person"]);
            s.Id_Client = Convert.ToInt32(r["id_Client"]);
            s.Id_Payment = Convert.ToInt32(r["id_Payment"]);
            s.Date = r["date"] == DBNull.Value ? default(DateTime) : Convert.ToDateTime(r["date"]);
            s.Total = Convert.ToDouble(r["total"]);
            s.State = ToStr(r["state"]);
            return s;
        }

        public int Create(Sale s)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            try
            {
                    string sql =
                        "INSERT INTO dbo.Sales (id_person, id_Client, id_Payment, date, total, state) " +
                        "VALUES (@person, @client, @payment, @date, @total, @state); " +
                        "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@person", s.Id_Person);
                    cmd.Parameters.AddWithValue("@client", s.Id_Client);
                    cmd.Parameters.AddWithValue("@payment", s.Id_Payment);
                    cmd.Parameters.AddWithValue("@date", s.Date);
                    cmd.Parameters.AddWithValue("@total", s.Total);
                    cmd.Parameters.AddWithValue("@state", s.State);

                        int newId = (int)cmd.ExecuteScalar();
                        return newId;
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        public List<Sale> GetAll()
        {
            List<Sale> list = new List<Sale>();
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = @"
                  SELECT 
                      s.id_Sale,
                      s.id_person,
                      s.id_client,
                      s.id_payment,
                      s.date,
                      s.total,
                      s.state
                  FROM dbo.Sales s
                 ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Sale view = new Sale
                            {
                                Id_Sale = Convert.ToInt32(r["id_Sale"]),
                                Id_Person = Convert.ToInt32(r["id_person"]),
                                Id_Client = Convert.ToInt32(r["id_client"]),
                                Id_Payment = Convert.ToInt32(r["id_payment"]),
                                Date = Convert.ToDateTime(r["date"]),
                                Total = Convert.ToDouble(r["total"]),
                                State = r["state"].ToString()
                            };
                            list.Add(view);
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

        public Sale GetById(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_Sale, date, total, " +
                    "state " +
                    "FROM dbo.Sales WHERE id_Sale=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

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

        public bool Update(Sale s)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                     "UPDATE dbo.Sales SET " +
                     "date=@fecha, total=@totall, state=@stado " +
                     "WHERE id_Sale=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", s.Id_Sale);
                    cmd.Parameters.AddWithValue("@fecha", s.Date);
                    cmd.Parameters.AddWithValue("@totall", s.Total);
                    cmd.Parameters.AddWithValue("@stado", s.State);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        public bool Delete(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = "DELETE FROM dbo.Sales WHERE id_Sale=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }
    }
}