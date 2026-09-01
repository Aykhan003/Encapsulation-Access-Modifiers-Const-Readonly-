using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class User
    {

        public string Username { get; set; }
        public string Password
        {
            get
            {
                return field;
            }
            set
            {
                PassCheck(value);
                field = value;
            }
        }

        private static void PassCheck(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Password cannot be null or empty.");
            }
            if (value.Length < 8 || value.Length > 100)
            {
                throw new ArgumentException("Password must be between 8 and 100 characters long.");
            }
            bool hasUppercase = false;
            bool hasDigit = false;
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            if (!hasUppercase)
            {
                throw new ArgumentException("Password must contain at least one uppercase letter.");
            }
            if (!hasDigit)
            {
                throw new ArgumentException("Password must contain at least one digit.");
            }
        }

        public int Age
        {
            get { return field; }
            set
            {
                if (value < 0 )
                    throw new ArgumentException("Age cannot be negative.");
                field = value;
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

    }
}
