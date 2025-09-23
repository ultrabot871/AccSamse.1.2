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
            try
            {
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
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        public void DeleteBySaleId(int saleId)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                string sql = "DELETE FROM SaleDetails WHERE id_Sale = @SaleId";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@SaleId", saleId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
