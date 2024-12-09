using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Customer
    {
        // Properties
        public string Role { get; set; }
        public string Status { get; set; }
        public string UserMail { get; set; }
        public int PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        // Constructor
        public Customer(string userMail, int phoneNumber, string street, string city, string postcode)
        {
            UserMail = userMail;
            PhoneNumber = phoneNumber;
            Street = street;
            City = city;
            Postcode = postcode;
        }

        // Method to create sample customers
        public static List<Customer> CreateSampleCustomers()
        {
            return new List<Customer>
            {
                new Customer("ruairi.oneill@gmail.com", 0774567890, "123 John Street", "Derry", "BT47 4HT"),
                new Customer("emma.conaghan@gmail.com", 0775432101, "456 Shipquay Street", "Derry", "BT48 4FR")
            };
        }

        // Method to display customer menu
        public static void DisplayCustomerMenu()
        {
            Console.WriteLine("Customer Menu:");
            Console.WriteLine("1. View Customers");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Exit");
        }

        // Display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Email: {UserMail}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Postcode: {Postcode}");
        }
    }

    class Program
    {
        static void main(string[] args)
        {
            // Sample usage
            List<Customer> customers = Customer.CreateSampleCustomers();

            // Display menu
            Customer.DisplayCustomerMenu();

            Console.WriteLine("\nSample Customers:");
            foreach (var customer in customers)
            {
                customer.DisplayCustomerDetails();
                Console.WriteLine();
            }

        }
    }
}
