using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.Models
{
    internal class Product
    {
        private int id_product;
        private string name;
        private string description;
        private decimal price;
        private int stock;
        private int id_Category;
        private string category;

        public Product()
        {
        }


        public Product(int id_product, string name, string description, decimal price, int stock, int id_Category, string Category)
        {
            this.id_product = id_product;
            this.name = name;
            this.description = description;
            this.price = price;
            this.stock = stock;
            this.id_Category = id_Category;
            this.Category = Category;
        }

        public int Id_product { get => id_product; set => id_product = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id_Category { get => id_Category; set => id_Category = value; }
        public string Category { get => category; set => category = value; }
    }
}
