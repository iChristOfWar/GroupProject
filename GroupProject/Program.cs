using System;
using GroupProject; // Assuming the User class is in this namespace

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
                string custUsername = Console.ReadLine().Trim(); // ensuring no spaces are carried into validation

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

    // Admin menu to manage users, view details, etc.
    static void adminMenu()
    {
        Console.WriteLine("Welcome to the Admin Menu.");

        // Example of Admin actions
        Console.WriteLine("1: View all users");
        Console.WriteLine("2: Modify user information");

        int adminChoice = Convert.ToInt32(Console.ReadLine());

        switch (adminChoice)
        {
            case 1:
                // Demo Users
                User user1 = new User(1, "cust001", "user123", "cust001@email.com", "555-1234", "123 Elm St", "Anytown");
                User user2 = new User(2, "cust002", "user123", "cust002@email.com", "555-5678", "456 Oak St", "Anytown");

                // Displaying users
                Console.WriteLine("Displaying User Info:");
                user1.DisplayUserInfo();
                user2.DisplayUserInfo();
                break;

            case 2:
                Console.WriteLine("Modify User Info Selected");
                // Logic for modifying user info would go here
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // User menu to view and modify details
    static void custUserMenu()
    {
        Console.WriteLine("Welcome to the User Menu.");

        // Example: User can view their details
        Console.WriteLine("1: View User Info");
        Console.WriteLine("2: Modify User Info");

        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                // Demo Users
                User currentUser = new User(1, "cust001", "user123", "cust001@email.com", "555-1234", "123 Elm St", "Anytown");

                // Displaying user info
                currentUser.DisplayUserInfo();
                break;

            case 2:
                Console.WriteLine("Modify User Info Selected");
                // Logic for modifying user info would go here
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
