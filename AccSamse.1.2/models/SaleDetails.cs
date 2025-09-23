using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    internal class SaleDetails
    {
        private int id_Details;
        private int id_Sale;
        private int id_Product;
        private int amount;
        private decimal unit_Price;
        private decimal subtotal;

        public SaleDetails()
        {
            
        }


        public SaleDetails(int id_Details, int amount, decimal unit_Price, decimal subtotal, int id_Sale, int id_Product)
        {
            this.Id_Details = id_Details;
            this.Amount = amount;
            this.Unit_Price = unit_Price;
            this.Subtotal = subtotal;
            this.Id_Sale = id_Sale;
            this.Id_Product = id_Product;
        }

        public int Id_Details { get => id_Details; set => id_Details = value; }
        public int Amount { get => amount; set => amount = value; }
        public decimal Unit_Price { get => unit_Price; set => unit_Price = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public int Id_Sale { get => id_Sale; set => id_Sale = value; }
        public int Id_Product { get => id_Product; set => id_Product = value; }
        
    }
}
