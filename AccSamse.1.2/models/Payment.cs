using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    internal class Payment
    {
        private int id_Payment;
        private decimal Amount;
        private string payment_Method;
        private DateTime payment_Date;

        public Payment()
        {
          
        }

        public Payment(int id_Payment, decimal amount, string payment_Method, DateTime payment_Date)
        {
            this.Id_Payment = id_Payment;
            Amount1 = amount;
            this.Payment_Method = payment_Method;
            this.Payment_Date = payment_Date;
        }

        public int Id_Payment { get => id_Payment; set => id_Payment = value; }
        public decimal Amount1 { get => Amount; set => Amount = value; }
        public string Payment_Method { get => payment_Method; set => payment_Method = value; }
        public DateTime Payment_Date { get => payment_Date; set => payment_Date = value; }
    }
}
