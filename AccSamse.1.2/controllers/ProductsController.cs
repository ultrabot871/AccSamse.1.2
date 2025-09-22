using AccSamse._1._2.models;
using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.controllers
{
    internal class ProductsController
    {
        // ===== Helpers =====
        private static string ToStr(object value)
        {
            return (value == null || value is DBNull) ? "" : value.ToString();
        }

        private static Product Map(SqlDataReader r)
        {
            Product p = new Product();
            p.Id_Product = Convert.ToInt32(r["id_product"]);
            p.Id_Category = Convert.ToInt32(r["id_category"]);
            p.Name = ToStr(r["name"]);
            p.Description = ToStr(r["description"]);
            p.Price = Convert.ToDecimal(r["price"]);
            p.Stock = Convert.ToInt32(r["stock"]);
            return p;
        }

        // ===== CREATE =====
        public bool Create(Product p)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();
            try
            {
                string sql =
                    "INSERT INTO dbo.Products (id_category, name, description, price, stock) " +
                    "VALUES (@cat, @name, @desc, @price, @stock)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cat", p.Id_Category);
                    cmd.Parameters.AddWithValue("@name", p.Name);
                    cmd.Parameters.AddWithValue("@desc", (object)p.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);

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
        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>();
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = "SELECT id_product, id_category, name, description, price, stock FROM dbo.Products";

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
        public Product GetById(int id)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql = @"SELECT p.id_product, p.id_category, p.name, p.description, p.price, p.stock,
                              c.name AS categoryName
                       FROM dbo.Products p
                       INNER JOIN dbo.Categories c ON p.id_category = c.id_category
                       WHERE p.id_product=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new Product
                            {
                                Id_Product = (int)r["id_product"],
                                Id_Category = (int)r["id_category"],
                                Name = r["name"].ToString(),
                                Description = r["description"].ToString(),
                                Price = (decimal)r["price"],
                                Stock = (int)r["stock"],
                                CategoryName = r["categoryName"].ToString() // 🔹 Aquí cargamos el nombre
                            };
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
        public bool Update(Product p)
        {
            SqlConnection conn = ConexionDataBase.GetConnection();

            try
            {
                string sql =
                    "UPDATE dbo.Products SET " +
                    "id_category=@cat, name=@name, description=@desc, price=@price, stock=@stock " +
                    "WHERE id_product=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id_Product);
                    cmd.Parameters.AddWithValue("@cat", p.Id_Category);
                    cmd.Parameters.AddWithValue("@name", p.Name);
                    cmd.Parameters.AddWithValue("@desc", (object)p.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);

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
                string sql = "DELETE FROM dbo.Products WHERE id_product=@id";

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

