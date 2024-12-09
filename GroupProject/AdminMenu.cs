using System;

namespace GroupProject
{
    class AdminMenu
    {
        static void Main(string[] args)
        {
            MainMenu.ShowMenu();
        }
    }

    public class MainMenu
    {
        public static void ShowMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                // Display Admin Menu
                Console.Clear();
                Console.WriteLine("----- Admin Panel -----");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Edit Products");
                Console.WriteLine("3. View Customers");
                Console.WriteLine("4. Edit Customers");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Products.DisplayProducts();
                        break;
                    case "2":
                       
                        Products.Products();
                        break;
                    case "3":
                        Customers.ViewCustomers();
                        break;
                    case "4":

                        Customers.ShowCustomerMenu();
                        break;
                    case "5":
                        isRunning = false;
                        Console.WriteLine("Exiting the Admin Panel");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select a valid option.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
};
       
