using System;
using System.Collections.Generic;
using GroupProject;

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();

        // Demo Users
        User user1 = new User(1, "cust001", "user123", "cust001@email.com", "123456", "123 Here St", "Anytown");
        User user2 = new User(2, "cust002", "user123", "cust002@email.com", "555-5678", "456 Oak St", "Anytown");

        // Add the demo users to the list
        users.Add(user1);
        users.Add(user2);

        // Display the main menu options
        Console.WriteLine("Main Menu:\nPlease select from the following:");
        Console.WriteLine("1: Admin Access");
        Console.WriteLine("2: Customer Access");

        // Read the user's input and attempt to convert it to an integer
        int menuSelection = Convert.ToInt32(Console.ReadLine());

        // Process the menu selection
        switch (menuSelection)
        {
            case 1:
                Console.WriteLine("Admin Access Selected");
                adminMenu(users);
                break;

            case 2:
                Console.WriteLine("Customer Access Selected");
                custUserMenu(users);
                break;

            default:
                Console.WriteLine("Please select a valid option.");
                break;
        }
    }

    // Admin menu to manage users, view details, etc.
    static void adminMenu(List<User> users)
    {
        Console.WriteLine("Welcome to the Admin Menu.");

        // Admin actions
        Console.WriteLine("1: View all users");
        Console.WriteLine("2: Modify user status");
        Console.WriteLine("3: Product Amendment");

        int adminChoice = Convert.ToInt32(Console.ReadLine());

        switch (adminChoice)
        {
            case 1:
                Console.WriteLine("Displaying User Info:");
                foreach (var user in users)
                {
                    user.DisplayUserInfo();
                }
                break;

            case 2:
                Console.WriteLine("Modify Customer Status");
                // Logic for modifying user info would go here
                break;

            case 3:
                Console.WriteLine("Product Amendment");
                // Logic for product amendment would go here
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // User menu to view and modify details
    static void custUserMenu(List<User> users)
    {
        Console.WriteLine("Welcome to your Customer Menu.");
        Console.WriteLine("Please enter your email address");
        string emailCheck = Console.ReadLine();

        // Find the user by email
        User currentUser = users.Find(u => u.Email == emailCheck);

        if (currentUser != null)
        {
            Console.WriteLine("Email verified. Please select an option:");
            Console.WriteLine("1: View User Info");
            Console.WriteLine("2: Modify User Info");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    // Displaying user info
                    Console.WriteLine("Displaying User Info:");
                    currentUser.DisplayUserInfo();
                    break;

                case 2:
                    Console.WriteLine("Modify User Info Selected - Please choose what modification is needed:");
                    Console.WriteLine("1: Update Email Address\n2: Update Password.");
                    int userModChoice = Convert.ToInt32(Console.ReadLine());
                    switch (userModChoice)
                    {
                        case 1:
                            Console.WriteLine("Please enter your current email address");
                            string currentEmail = Console.ReadLine();
                            if (currentEmail == currentUser.Email)
                            {
                                Console.WriteLine("Please enter new email address");
                                string updatedEmail = Console.ReadLine();
                                currentUser.Email = updatedEmail;  // Update email
                                Console.WriteLine("Email updated successfully.");
                                Console.WriteLine("If you wish to return to Main Menu enter 1. If you wish to exit enter 0"); // Option to return to menu
                                int menuSelection = Convert.ToInt32(Console.ReadLine());
                                if (menuSelection == 1)
                                {
                                    custUserMenu(users);
                                }
                                if (menuSelection == 2)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not a valid email account");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Please confirm your existing password");
                            string currentPassword = Console.ReadLine();
                            if (currentPassword == currentUser.Password)
                            {
                                Console.WriteLine("Please enter new password");
                                string updatedPassword = Console.ReadLine();
                                currentUser.Password = updatedPassword; // Update password
                                Console.WriteLine("Password updated successfully.");
                                Console.WriteLine("If you wish to return to Main Menu enter 1. If you wish to exit enter 0"); // Option to return to menu
                                int menuSelection2 = Convert.ToInt32(Console.ReadLine());
                                if (menuSelection2 == 1)
                                {
                                    custUserMenu(users);
                                }
                                if (menuSelection2 == 2)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not a valid password");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("No user found with that email.");
        }
    }
}
