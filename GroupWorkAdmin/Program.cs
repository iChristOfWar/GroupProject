using System;
using System.Collections.Generic;

namespace ShopAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu.ShowMenu();
        }
    }

    public class Product
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

        public Product(string name, decimal price, string description, string category, int stock)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.category = category;
            this.stock = stock;
        }
    }

    public class MainMenu
    {
        public static void ShowMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("-----Admin Panel-----");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Edit/Add Products");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayProducts();
                        break;
                    case "2":
                        Products();
                        break;
                    case "3":
                        isRunning = false;
                        Console.WriteLine("Exiting the admin panel");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select a valid option.");
                        break;
                }
            }
        }

        private static Dictionary<string, List<Product>> categorisedProducts = new Dictionary<string, List<Product>>
        {
              { "Books", new List<Product>
                    {
                        new Product("C# for Beginners", 500, "An introductory guide to C# programming.", "Books", 100),
                        new Product("Ultimate C#", 700, "An advanced guide to mastering C#.", "Books", 50),
                        new Product("Java Fundamentals", 600, "Learn the basics of Java programming.", "Books", 80),
                        new Product("Python Cookbook", 900, "A collection of Python programming recipes.", "Books", 40)
                    }
                },
                { "Electronics", new List<Product>
                    {
                        new Product("Wireless Mouse", 1500, "Ergonomic wireless mouse with adjustable DPI.", "Electronics", 200),
                        new Product("Gaming Keyboard", 4500, "Mechanical keyboard with RGB lighting.", "Electronics", 80),
                        new Product("Bluetooth Speaker", 3000, "Portable speaker with 10-hour battery life.", "Electronics", 150),
                        new Product("4K Monitor", 20000, "Ultra HD monitor with stunning color accuracy.", "Electronics", 30)
                    }
                },
                { "Clothing", new List<Product>
                    {
                        new Product("Running Shoes", 2500, "Lightweight and comfortable running shoes.", "Clothing", 120),
                        new Product("Leather Jacket", 8000, "Stylish leather jacket for all seasons.", "Clothing", 40),
                        new Product("T-Shirt Pack", 1500, "Pack of 3 high-quality cotton T-shirts.", "Clothing", 200),
                        new Product("Winter Coat", 12000, "Warm and durable winter coat.", "Clothing", 25)
                    }
                },
                { "Home Appliances", new List<Product>
                    {
                        new Product("Coffee Maker", 3500, "Automatic coffee maker with timer.", "Home Appliances", 30),
                        new Product("Vacuum Cleaner", 7000, "Powerful vacuum cleaner with HEPA filter.", "Home Appliances", 25),
                        new Product("Air Fryer", 5000, "Compact air fryer for healthy cooking.", "Home Appliances", 50),
                        new Product("Microwave Oven", 15000, "Multi-function microwave with smart settings.", "Home Appliances", 15)
                    }
                },
                { "Furniture", new List<Product>
                    {
                        new Product("Office Chair", 10000, "Ergonomic office chair with lumbar support.", "Furniture", 10),
                        new Product("Dining Table", 25000, "Wooden dining table for 6 people.", "Furniture", 5),
                        new Product("Bookshelf", 8000, "Spacious bookshelf with multiple compartments.", "Furniture", 12),
                        new Product("Sofa Set", 50000, "Comfortable and stylish 3-piece sofa set.", "Furniture", 3)
                    }
                },
                { "Toys", new List<Product>
                    {
                        new Product("Building Blocks", 1200, "Educational toy for kids aged 3 and above.", "Toys", 150),
                        new Product("Remote Control Car", 3000, "High-speed remote control car.", "Toys", 100),
                        new Product("Dollhouse", 5000, "Beautiful dollhouse with furniture.", "Toys", 30),
                        new Product("Puzzle Game", 700, "Brain-teasing puzzle for all ages.", "Toys", 200)
                    }
            }
        };

        private static void Products()
        {
            Console.Clear();
            Console.WriteLine("-----Products-----");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Edit Existing Product");
            Console.WriteLine("3. Delete a Product");
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
                    EditProduct();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please select a valid option.");
                    break;
            }
        }


        private static void DisplayProducts()
        {

            ProductPage.ShowProducts(categorisedProducts);


            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
        }



        private static void AddProduct()
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
                categorisedProducts[category] = new List<Product>();
            }

            categorisedProducts[category].Add(new Product(name, price, description, category, stock));
            Console.WriteLine("Product added successfully!");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        private static void EditProduct()
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
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }
    }




    public static class ProductPage
    {
        public static void ShowProducts(Dictionary<string, List<Product>> categorisedProducts)
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