using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Controllers
{
    internal class ProductsController
    {
        private static string ToStr(object value)
        {
            return (value == null || value is DBNull) ? "" : value.ToString();
        }

        private static Product Map(SqlDataReader r)
        {
            Product u = new Product();
            u.Id_product = Convert.ToInt32(r["id_Product"]);
            u.Name = ToStr(r["name"]);
            u.Description = ToStr(r["description"]);
            u.Price = Convert.ToDecimal(r["id_Product"]);
            u.Stock = Convert.ToInt32(r["decimal"]);
            return u;
        }

        public Product GetById(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "SELECT id_product, name, description, " +
                    "price, stock, category" +
                    "FROM dbo.Products WHERE id_product=@id";

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
    }
}
