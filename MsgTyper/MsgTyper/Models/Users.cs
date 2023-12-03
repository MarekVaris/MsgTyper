using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MsgTyper.Models
{
    public class Users
    {
        public class User
        {
            // Encapsulation: private fields
            private string username;
            private UserRole role;

            public DateTime Created_in { get; set; }

            // Encapsulation: properties to access fields
            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public UserRole Role
            {
                get { return role; }
                set { role = value; }
            }

            // Polymorphism: virtual method
            public virtual string GetWelcomeMessage()
            {
                return username;
            }
        }

        public class AdminUser : User
        {
            private string password;

            // Encapsulation
            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            // Inheritance
            public AdminUser(string username, string password)
            {
                Username = username;
                Password = password;
                Role = UserRole.Admin;

                Created_in = DateTime.Now;
            }

        }

        public class NormalUser : User
        {
            private string password;

            // Encapsulation
            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            // Inheritance
            public NormalUser(string username, string password)
            {
                Username = username;
                Password = password;
                Role = UserRole.Normal;

                Created_in = DateTime.Now;
            }
        }

        public class Guest : User
        {
            public Guest(string username)
            {
                Username = username;
                Role = UserRole.Guest;

                Created_in = DateTime.Now;
            }
        }

        // Enumeration for classes
        public enum UserRole
        {
            Guest,
            Admin,
            Normal
        }
    }
}
