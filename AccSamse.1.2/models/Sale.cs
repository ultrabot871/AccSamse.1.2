using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    internal class Sale
    {
        private int id_Sale;
        private int id_Person;
        private int id_Client;
        private int id_Payment;
        private DateTime date;
        private double total;
        private string state;

        public Sale()
        {
        }


        public Sale(int id_Sale, DateTime date, double total, string state, int id_Person, int id_Client, int id_Payment)
        {
            this.id_Sale = id_Sale;
            this.date = date;
            this.total = total;
            this.state = state;
            this.Id_Person = id_Person;
            this.Id_Client = id_Client;
            this.Id_Payment = id_Payment;
        }

        public int Id_Sale { get => id_Sale; set => id_Sale = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Total { get => total; set => total = value; }
        public string State { get => state; set => state = value; }
        public int Id_Person { get => id_Person; set => id_Person = value; }
        public int Id_Client { get => id_Client; set => id_Client = value; }
        public int Id_Payment { get => id_Payment; set => id_Payment = value; }
    }
}
