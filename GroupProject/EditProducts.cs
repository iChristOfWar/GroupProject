using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Products
    {
        public static Dictionary<string, List<Products>> categorisedProducts = new Dictionary<string, List<Products>>
        {
            { "Books", new List<Products>
                    {
                        new Products("C# for Beginners", 500, "An introductory guide to C# programming.", "Books", 100),
                        new Products("Ultimate C#", 700, "An advanced guide to mastering C#.", "Books", 50),
                        new Products("Java Fundamentals", 600, "Learn the basics of Java programming.", "Books", 80),
                        new Products("Python Cookbook", 900, "A collection of Python programming recipes.", "Books", 40)
                    }
                },
                { "Electronics", new List<Products>
                    {
                        new Products("Wireless Mouse", 1500, "Ergonomic wireless mouse with adjustable DPI.", "Electronics", 200),
                        new Products("Gaming Keyboard", 4500, "Mechanical keyboard with RGB lighting.", "Electronics", 80),
                        new Products("Bluetooth Speaker", 3000, "Portable speaker with 10-hour battery life.", "Electronics", 150),
                        new Products("4K Monitor", 20000, "Ultra HD monitor with stunning color accuracy.", "Electronics", 30)
                    }
                },
                { "Clothing", new List<Products>
                    {
                        new Products("Running Shoes", 2500, "Lightweight and comfortable running shoes.", "Clothing", 120),
                        new Products("Leather Jacket", 8000, "Stylish leather jacket for all seasons.", "Clothing", 40),
                        new Products("T-Shirt Pack", 1500, "Pack of 3 high-quality cotton T-shirts.", "Clothing", 200),
                        new Products("Winter Coat", 12000, "Warm and durable winter coat.", "Clothing", 25)
                    }
                },
                { "Home Appliances", new List<Products>
                    {
                        new Products("Coffee Maker", 3500, "Automatic coffee maker with timer.", "Home Appliances", 30),
                        new Products("Vacuum Cleaner", 7000, "Powerful vacuum cleaner with HEPA filter.", "Home Appliances", 25),
                        new Products("Air Fryer", 5000, "Compact air fryer for healthy cooking.", "Home Appliances", 50),
                        new Products("Microwave Oven", 15000, "Multi-function microwave with smart settings.", "Home Appliances", 15)
                    }
                },
                { "Furniture", new List<Products>
                    {
                        new Products("Office Chair", 10000, "Ergonomic office chair with lumbar support.", "Furniture", 10),
                        new Products("Dining Table", 25000, "Wooden dining table for 6 people.", "Furniture", 5),
                        new Products("Bookshelf", 8000, "Spacious bookshelf with multiple compartments.", "Furniture", 12),
                        new Products("Sofa Set", 50000, "Comfortable and stylish 3-piece sofa set.", "Furniture", 3)
                    }
                },
                { "Toys", new List<Products>
                    {
                        new Products("Building Blocks", 1200, "Educational toy for kids aged 3 and above.", "Toys", 150),
                        new Products("Remote Control Car", 3000, "High-speed remote control car.", "Toys", 100),
                        new Products("Dollhouse", 5000, "Beautiful dollhouse with furniture.", "Toys", 30),
                        new Products("Puzzle Game", 700, "Brain-teasing puzzle for all ages.", "Toys", 200)
                    }
            }
        };
        public static void DisplayProducts()
        {
            Console.Clear();
            Console.WriteLine("-----Product List-----");
            decimal overallTotalValue = 0;
            int overallTotalStock = 0;

            foreach (var category in categorisedProducts)
            {
                Console.WriteLine($"\nCategory: {category.Key}");
                decimal categoryTotalValue = 0;
                int categoryTotalStock = 0;

                foreach (var product in category.Value)
                {
                    Console.WriteLine($"- {product.Name} | Price: {product.Price:C} | Stock: {product.Stock} | Description: {product.Description}");
                    categoryTotalValue += product.Price * product.Stock;
                    categoryTotalStock += product.Stock;
                }

                Console.WriteLine($"\nTotal Value for {category.Key}: {categoryTotalValue:C}");
                Console.WriteLine($"Total Stock for {category.Key}: {categoryTotalStock}");

                overallTotalValue += categoryTotalValue;
                overallTotalStock += categoryTotalStock;
            }
            Console.WriteLine($"\n-----Overall Totals-----");
            Console.WriteLine($"Overall Total Value: {overallTotalValue:C}");
            Console.WriteLine($"Overall Total Stock: {overallTotalStock}");

            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
        }

        public static void Products()
        {
            Console.Clear();
            Console.WriteLine("-----Products-----");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Edit Existing Product");
            Console.WriteLine("3. Remove Product");
            Console.WriteLine("4. Return to Main Menu");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    EditProduct();
                    break;
                case "3":
                    RemoveProduct();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please select a valid option.");
                    break;
            }
        }

        public static void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("Remove Product");
            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            if (!categorisedProducts.ContainsKey(category))
            {
                Console.WriteLine("Category not found");
                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Available Products");
            var products = categorisedProducts[category];
            for (int i = 0; i < products.Count; i++)

            {
                Console.WriteLine($"{i + 1}. {products[i].Name}");
            }

            Console.Write("Select a product to remove (enter the number): ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= products.Count)
            {
                Console.WriteLine("Invalid product selection.");
                Console.WriteLine("Press any Key to return");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Are you sure you want to remove {products[index].Name}? (y/n): ");
            string confirmation = Console.ReadLine();
            if (confirmation?.ToLower() == "y")
            {
                products.RemoveAt(index);
                Console.WriteLine("Product Removed");
            }

            else
            {
                Console.WriteLine("Removal Cancelled");
            }
            Console.WriteLine("Press any Key to return");
            Console.ReadKey();
        }







        public static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Add New Product");
            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());

            if (!categorisedProducts.ContainsKey(category))
            {
                categorisedProducts[category] = new List<Products>();
            }

            categorisedProducts[category].Add(new Products(name, price, description, category, stock));
            Console.WriteLine("Product added successfully!");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        public static void EditProduct()
        {
            Console.Clear();
            Console.WriteLine("Edit Existing Product");
            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            if (!categorisedProducts.ContainsKey(category))
            {
                Console.WriteLine("Category not found.");
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Available Products:");
            var products = categorisedProducts[category];
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name}");
            }

            Console.Write("Select a product to edit (enter the number): ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= products.Count)
            {
                Console.WriteLine("Invalid product selection.");
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
                return;
            }

            var product = products[index];
            Console.WriteLine($"Editing Product: {product.Name}");

            Console.Write("Enter New Name (leave empty to keep current): ");
            string newName = Console.ReadLine();

            Console.Write("Enter New Price (leave empty to keep current): ");
            string newPrice = Console.ReadLine();

            Console.Write("Enter New Description (leave empty to keep current): ");
            string newDescription = Console.ReadLine();

            Console.Write("Enter New Stock Quantity (leave empty to keep current): ");
            string newStock = Console.ReadLine();

            if (!string.IsNullOrEmpty(newName)) product.Name = newName;
            if (!string.IsNullOrEmpty(newPrice)) product.Price = decimal.Parse(newPrice);
            if (!string.IsNullOrEmpty(newDescription)) product.Description = newDescription;
            if (!string.IsNullOrEmpty(newStock)) product.Stock = int.Parse(newStock);

            Console.WriteLine("Product updated successfully!");
            Console.WriteLine("\nPress any key to return and save all products");
            Console.ReadKey();
        }
    }

    public static class ProductPage
    {
        public static void ShowProducts(Dictionary<string, List<Products>> categorisedProducts)
        {
            foreach (var category in categorisedProducts)
            {
                Console.WriteLine($"\nCategory: {category.Key}");
                foreach (var product in category.Value)
                {
                    Console.WriteLine($"- {product.Name} | Price: {product.Price} | Stock: {product.Stock} | Description: {product.Description}");
                }
            }
        }
    }
}


