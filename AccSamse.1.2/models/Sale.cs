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
        private DateTime date;
        private double total;
        private string state;

        public Sale(int id_Sale, DateTime date, double total, string state)
        {
            this.id_Sale = id_Sale;
            this.date = date;
            this.total = total;
            this.state = state;
        }

        public int Id_Sale { get => id_Sale; set => id_Sale = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Total { get => total; set => total = value; }
        public string State { get => state; set => state = value; }
    }
}
