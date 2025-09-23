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
            u.Id_product = Convert.ToInt32(r["id_product"]);
            u.Id_Category = Convert.ToInt32(r["id_Category"]);
            u.Name = ToStr(r["name"]);
            u.Description = ToStr(r["description"]);
            u.Price = Convert.ToDecimal(r["price"]);
            u.Stock = Convert.ToInt32(r["stock"]);
            u.Category = ToStr(r["category"]); // 👈 ahora sí existe
            return u;
        }

        public Product GetById(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = @"
                 SELECT p.id_product,
                        p.id_Category,
                        p.name, 
                        p.description, 
                        p.price, 
                        p.stock, 
                        c.name AS category
                 FROM dbo.Products p
                 INNER JOIN dbo.Categories c ON p.id_Category = c.id_Category";

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

        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>();
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = @"
                 SELECT p.id_product, 
                        p.id_Category,
                        p.name, 
                        p.description, 
                        p.price, 
                        p.stock, 
                        c.name AS category
                 FROM dbo.Products p
                 INNER JOIN dbo.Categories c ON p.id_Category = c.id_Category";

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
    }
}
