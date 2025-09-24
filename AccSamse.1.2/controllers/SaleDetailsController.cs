using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Controllers
{
    internal class SaleDetailsController
    {
        public bool Create(SaleDetails sd)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                string sql =
                    "INSERT INTO dbo.SaleDetails (id_Sale, id_Product, Amount, unit_Price, subtotal) " +
                    "VALUES (@sale, @product, @amount, @price, @subtotal)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sale", sd.Id_Sale);
                    cmd.Parameters.AddWithValue("@product", sd.Id_Product);
                    cmd.Parameters.AddWithValue("@amount", sd.Amount);
                    cmd.Parameters.AddWithValue("@price", sd.Unit_Price);
                    cmd.Parameters.AddWithValue("@subtotal", sd.Subtotal);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public void DeleteBySaleId(int saleId)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM SaleDetails WHERE id_Sale = @SaleId";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@SaleId", saleId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ===== READ BY SALE ID =====
        public List<SaleDetails> GetBySaleId(int saleId)
        {
            var list = new List<SaleDetails>();

            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id_sale, id_product, amount, unit_price, subtotal " +
                             "FROM dbo.SaleDetails WHERE id_sale = @idSale";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idSale", saleId);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            SaleDetails sd = new SaleDetails
                            {
                                Id_Sale = Convert.ToInt32(r["id_sale"]),
                                Id_Product = Convert.ToInt32(r["id_product"]),
                                Amount = Convert.ToInt32(r["amount"]),
                                Unit_Price = Convert.ToDecimal(r["unit_price"]),
                                Subtotal = Convert.ToDecimal(r["subtotal"])
                            };
                            list.Add(sd);
                        }
                    }
                }
            }

            return list;
        }


    }
}
