using System;

namespace GroupProject
{
    internal class User
    {
        // Private fields
        private int id;
        private string username;
        private string password;
        private string email;
        private string phoneNumber;
        private string streetAddress;
        private string cityAddress;

        // Public properties with custom get and set
        public int ID
        {
            get { return id; }
            private set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username cannot be empty.");
                }
                username = value;
            }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string CityAddress
        {
            get { return cityAddress; }
            set { cityAddress = value; }
        }

        // Constructor
        public User(int id, string username, string password, string email, string phoneNumber, string streetAddress, string cityAddress)
        {
            this.id = id; 
            this.username = username;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.streetAddress = streetAddress;
            this.cityAddress = cityAddress;
        }

        // Method to display user info
        public void DisplayUserInfo()
        {
            Console.WriteLine($"ID: {ID}\nUsername: {Username}\nEmail: {Email}\nPhone: {PhoneNumber}\nAddress: {StreetAddress}, {CityAddress}");
        }
    }
}
