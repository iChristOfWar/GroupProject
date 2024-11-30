using System;

class Program
{
    static void Main()
    {
        // Display the main menu options
        Console.WriteLine("Main Menu:\nPlease select from the following:");
        Console.WriteLine("1: Admin Access");
        Console.WriteLine("2: User Access");

        // Read the user's input and attempt to convert it to an integer
        int menuSelection = Convert.ToInt32(Console.ReadLine());

        // Process the menu selection
        switch (menuSelection)
        {
            case 1:
                Console.WriteLine("Admin Access Selected");

                // Ask for Admin Username
                Console.WriteLine("Please enter Admin Username:");
                string adminUsername = Console.ReadLine().Trim();

                // Validate the username
                string[] adminList = { "admin", "root" };

                bool isAdminValid = false;
                foreach (var validUsername in adminList)
                {
                    if (string.Equals(adminUsername, validUsername))
                    {
                        isAdminValid = true;
                        break;
                    }
                }

                if (!isAdminValid)
                {
                    Console.WriteLine("Invalid Admin Username.");
                    return;
                }

                // Ask for Admin Password
                Console.WriteLine("Please enter Admin Password:");
                string adminPassword = Console.ReadLine().Trim(); // ensuring no spaces are carried into validation

                // Validate password 
                string correctAdminPassword = "admin123";

                if (adminPassword == correctAdminPassword)
                {
                    Console.WriteLine("Admin login successful.");
                    adminMenu(); // Admin menu loaded after successful login
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }
                break;

            case 2:
                Console.WriteLine("User Access Selected");

                // Ask for Username
                Console.WriteLine("Please enter Username:");
                string custUsername = Console.ReadLine().Trim(); // ensuring no spaces are carried into validatio

                // Validate the Username
                string[] custList = { "cust001", "cust002" };

                bool isCustValid = false;
                foreach (var validUsername in custList)
                {
                    if (string.Equals(custUsername, validUsername))
                    {
                        isCustValid = true;
                        break;
                    }
                }

                if (!isCustValid)
                {
                    Console.WriteLine("Invalid Username.");
                    return;
                }

                // Ask for User Password
                Console.WriteLine("Please enter Password:");
                string userPassword = Console.ReadLine().Trim();

                // Validate password 
                string correctUserPassword = "user123";

                if (userPassword == correctUserPassword)
                {
                    Console.WriteLine("User login successful.");
                    custUserMenu(); // User menu after successful login
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }
                break;

            default:
                Console.WriteLine("Please select a valid option.");
                break;
        }
    }


    // Admin menu to be completed
    static void adminMenu()
    {
        Console.WriteLine("Welcome to the Admin Menu.");

    }

    // User menu to be completed
    static void custUserMenu()
    {
        Console.WriteLine("Welcome to the User Menu.");

    }
}
