using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWorkAdmin
{
   
    public class Products
    {
        private string name;
        private decimal price;
        private string description;
        private string category;
        private int stock;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Products(string name, decimal price, string description, string category, int stock)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.category = category;
            this.stock = stock;
        }
    }
}
