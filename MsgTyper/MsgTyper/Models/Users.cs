using MsgTyper.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace MsgTyper.Models
{
    public class Users
    {
        public class User
        {
            // Encapsulation: private fields
            private string username;
            private string password;
            private UserRole role;
            public DateTime Created_in { get; set; }


            // Encapsulation: properties to access fields
            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
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

            // Inheritance
            public NormalUser(string username, string password)
            {
                Username = username;
                Password = password;
                Role = UserRole.Normal;
                Created_in = DateTime.Today;
            }
        }

        public class Guest : User
        {
            public Guest(string username)
            {
                Username = username;
                Password = "pass";
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


        public static User[] LoadJson()
        {
            // Trying to load the data json
            try
            {
                string json = File.ReadAllText("users.json");
                User[] users = JsonConvert.DeserializeObject<User[]>(json);

                return users;
            }
            catch
            {
                MessageBox.Show("Failed to load the file, creating a new file");

                // Creating a default AdminUser for demonstration
                User[] defaultUsers = { new AdminUser("admin", "admin") };

                string defaultJson = JsonConvert.SerializeObject(defaultUsers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("users.json", defaultJson);

                // Returning the default user
                return defaultUsers;
            }
        }

        public static void CreateNormal(string username, string password)
        {

            // Load users from JSON
            User[] existingUsers = LoadJson();

            // Create a new user (replace "newUser" with actual data)
            NormalUser newUser = new NormalUser(username, password);

            // Add the new user to the existing users array
            Array.Resize(ref existingUsers, existingUsers.Length + 1);
            existingUsers[existingUsers.Length - 1] = newUser;

            // Save the updated users array back to JSON
            string updatedJson = JsonConvert.SerializeObject(existingUsers, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", updatedJson);

            MessageBox.Show("New accout has been created.");
        }
        
    }
}