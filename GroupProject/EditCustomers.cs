// Customers.cs
using System;
using System.Collections.Generic;

namespace GroupProject
{
    public class Customers
    {
        private static List<Customer> customers = Customer.CreateSampleCustomers();

        public static void ShowCustomerMenu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("----- Customer Menu -----");
                Console.WriteLine("1. View All Customers");
                Console.WriteLine("2. Add New Customer");
                Console.WriteLine("3. Edit Existing Customer");
                Console.WriteLine("4. Remove Customer");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewCustomers();
                        break;
                    case "2":
                        AddCustomer();
                        break;
                    case "3":
                        EditCustomer();
                        break;
                    case "4":
                        RemoveCustomer();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        public static void ViewCustomers()
        {
            Console.Clear();
            Console.WriteLine("----- Customer List -----");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"\nCustomer {i + 1}:");
                customers[i].DisplayCustomerDetails();
            }
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        public static void AddCustomer()
        {
            Console.Clear();
            Console.WriteLine("----- Add New Customer -----");
            Console.Write("Enter Email: ");
            string userMail = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Street: ");
            string street = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.Write("Enter Postcode: ");
            string postcode = Console.ReadLine();

            customers.Add(new Customer(userMail, phoneNumber, street, city, postcode));
            Console.WriteLine("Customer added successfully!");
            Console.ReadKey();
        }

        public static void EditCustomer()
        {
            Console.Clear();
            ViewCustomers();

            Console.Write("Enter the number of the customer to edit: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= customers.Count)
            {
                var customer = customers[index - 1];
                Console.Write("Enter New Email (leave blank to keep unchanged): ");
                string userMail = Console.ReadLine();
                Console.Write("Enter New Phone Number (leave blank to keep unchanged): ");
                string phoneInput = Console.ReadLine();
                Console.Write("Enter New Street (leave blank to keep unchanged): ");
                string street = Console.ReadLine();
                Console.Write("Enter New City (leave blank to keep unchanged): ");
                string city = Console.ReadLine();
                Console.Write("Enter New Postcode (leave blank to keep unchanged): ");
                string postcode = Console.ReadLine();

                if (!string.IsNullOrEmpty(userMail)) customer.UserMail = userMail;
                if (!string.IsNullOrEmpty(phoneInput) && int.TryParse(phoneInput, out int phoneNumber)) customer.PhoneNumber = phoneNumber;
                if (!string.IsNullOrEmpty(street)) customer.Street = street;
                if (!string.IsNullOrEmpty(city)) customer.City = city;
                if (!string.IsNullOrEmpty(postcode)) customer.Postcode = postcode;

                Console.WriteLine("Customer updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
            Console.ReadKey();
        }

        public static void RemoveCustomer()
        {
            Console.Clear();
            ViewCustomers();

            Console.Write("Enter the number of the customer to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= customers.Count)
            {
                customers.RemoveAt(index - 1);
                Console.WriteLine("Customer removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
            Console.ReadKey();
        }
    }
}
