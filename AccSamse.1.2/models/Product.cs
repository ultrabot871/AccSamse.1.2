using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.models
{
    internal class Product
    {
        private int id_product;
        private int id_category;
        private string name;
        private string description;
        private decimal price;
        private int stock;
        private string categoryName;

        public Product(int id_product, int id_category, string name, string description, decimal price, int stock, string categoryName)
        {
            this.id_product = id_product;
            this.id_category = id_category;
            this.name = name;
            this.description = description;
            this.price = price;
            this.stock = stock;
            this.categoryName = categoryName;
        }

        public Product() { }

        public int Id_Product { get => id_product; set => id_product = value; }
        public int Id_Category { get => id_category; set => id_category = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

    }
}

