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
            return new Product
            {
                Id_product = Convert.ToInt32(r["id_product"]),
                Id_Category = Convert.ToInt32(r["id_Category"]),
                Name = ToStr(r["name"]),
                Description = ToStr(r["description"]),
                Price = Convert.ToDecimal(r["price"]),
                Stock = Convert.ToInt32(r["stock"]),
                Category = ToStr(r["category"]) // viene del JOIN
            };
        }

        // ===== READ BY ID =====
        public Product GetById(int id)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT p.id_product,
                           p.id_Category,
                           p.name, 
                           p.description, 
                           p.price, 
                           p.stock, 
                           c.name AS category
                    FROM dbo.Products p
                    INNER JOIN dbo.Categories c ON p.id_Category = c.id_Category
                    WHERE p.id_product = @id";   // 👈 faltaba el WHERE

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
            }

            return null;
        }

        // ===== READ ALL =====
        public List<Product> GetAll()
        {
            var list = new List<Product>();

            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

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

            return list;
        }

        // ===== CREATE =====
        public bool Create(Product p)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

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
        }

        // ===== UPDATE =====
        public bool Update(Product p)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                string sql =
                    "UPDATE dbo.Products SET " +
                    "id_category=@cat, name=@name, description=@desc, price=@price, stock=@stock " +
                    "WHERE id_product=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id_product);
                    cmd.Parameters.AddWithValue("@cat", p.Id_Category);
                    cmd.Parameters.AddWithValue("@name", p.Name);
                    cmd.Parameters.AddWithValue("@desc", (object)p.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);

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

                // Primero verificamos si hay ventas con ese producto
                string checkSql = "SELECT COUNT(*) FROM dbo.SaleDetails WHERE id_Product=@id";
                using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", id);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // Hay ventas, no se puede borrar
                        return false;
                    }
                }

                // Si no hay ventas, se puede borrar
                string sql = "DELETE FROM dbo.Products WHERE id_product=@id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // ===== CATEGORY EXISTS =====
        public bool CategoryExists(int categoryId)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM Categories WHERE Id_Category = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool UpdateStock(int productId, int quantitySold)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE dbo.Products SET stock = stock - @qty WHERE id_product = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@qty", quantitySold);
                    cmd.Parameters.AddWithValue("@id", productId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public bool RestoreStock(int productId, int quantity)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE dbo.Products SET stock = stock + @qty WHERE id_product = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@id", productId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ===== GET CATEGORIES =====
        public List<(int Id, string Name)> GetCategories()
        {
            var categorias = new List<(int, string)>();

            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                string sql = "SELECT Id_Category, Name FROM Categories";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add((reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }

            return categorias;
        }

    }
}
