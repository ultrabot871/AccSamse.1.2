using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Controllers
{
    internal class PaymentsController
    {
        // ===== CREATE =====
        public int Create(Payment p)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open(); // Aseguramos abrir la conexión

                string sql =
                    "INSERT INTO dbo.Payments (Amount, Payment_Method, Payment_Date) " +
                    "VALUES (@amount, @method, @date); " +
                    "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@amount", p.Amount1);
                    cmd.Parameters.AddWithValue("@method", p.Payment_Method);
                    cmd.Parameters.AddWithValue("@date", p.Payment_Date);

                    int newId = (int)cmd.ExecuteScalar();
                    return newId;
                }
            }
        }

        public void Update(Payment payment)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = @"
                 UPDATE Payments
                 SET Amount = @Amount,
                 Payment_Method = @Method,
                 Payment_Date = @Date
                 WHERE id_payment = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Amount", payment.Amount1);
                    cmd.Parameters.AddWithValue("@Method", payment.Payment_Method);
                    cmd.Parameters.AddWithValue("@Date", payment.Payment_Date);
                    cmd.Parameters.AddWithValue("@Id", payment.Id_Payment);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Payment GetPaymentById(int idPayment)
        {
            Payment payment = null;

            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();
                string sql = @"
                 SELECT id_payment, amount, payment_method, payment_date
                 FROM dbo.Payments
                 WHERE id_payment = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPayment);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            payment = new Payment
                            {
                                Id_Payment = Convert.ToInt32(reader["id_payment"]),
                                Amount1 = Convert.ToDecimal(reader["amount"]),
                                Payment_Method = reader["payment_method"].ToString(),
                                Payment_Date = Convert.ToDateTime(reader["payment_date"])
                            };
                        }
                    }
                }
            }

            return payment;
        }



    }
}
