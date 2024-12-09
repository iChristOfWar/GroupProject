using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class ShoppingBasket
    {
        private List<Product> products;
        public User BasketUser { get; set; }

        public ShoppingBasket(User user)
        {
            BasketUser = user;
            products = new List<Product>();
        }

        // Add Item
        public void AddItem(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.ProductName} has been added to the basket.");
        }

        // Remove Item
        public void RemoveItem(string productID)
        {
            var productToRemove = products.Find(p => p.ProductID == productID);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine($"{productToRemove.ProductName} has been removed from the basket.");
            }
            else
            {
                Console.WriteLine("Product not found in the basket.");
            }
        }

        // View Basket
        public void ViewBasket()
        {
            Console.WriteLine($"Shopping Basket for {BasketUser.Username}:");
            if (products.Count == 0)
            {
                Console.WriteLine("Your basket is empty.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"- {product.ProductName} ({product.ProductID}): ${product.ProductPrice}");
                }
            }
        }
    }
}

    

