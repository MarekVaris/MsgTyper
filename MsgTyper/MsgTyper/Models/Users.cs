using MsgTyper.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using System.Diagnostics;
using static MsgTyper.Models.Users;

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

            public string Created_in { get; set; }

            // Polymorphism: virtual method
            public virtual string GetWelcomeMessage()
            {
                return username;
            }
        }

        public class AdminUser : User
        {
            private DateTime dateTime = DateTime.Now;
            // Inheritance
            public AdminUser(string username, string password)
            {
                Username = username;
                Password = password;
                Role = UserRole.Admin;
                Created_in = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }

        }

        public class NormalUser : User
        {
            private DateTime dateTime = DateTime.Now;
            // Inheritance
            public NormalUser(string username, string password)
            {
                Username = username;
                Password = password;
                Role = UserRole.Normal;
                Created_in = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        public class Guest : User
        {

            private DateTime dateTime = DateTime.Now;
            // Inheritance
            public Guest()
            {
                Username = dateTime.ToString("yyyyddss");
                Username = "Guest_"+Username;
                Password = "pass";
                Role = UserRole.Guest;
                Created_in = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        // Enumeration for classes
        public enum UserRole
        {
            Admin = 1,
            Normal,
            Guest
        }


        public static void SaveJson(User[] users_list )
        {
            string default_json = JsonConvert.SerializeObject(users_list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", default_json);
        }

        public static User[] LoadJson()
        {
            // Trying to load the data json
            try
            {
                string json = File.ReadAllText("users.json");
                User[] users = JsonConvert.DeserializeObject<User[]>(json);
                if (users == null || users.Length == 0)
                {
                    // Creating a default AdminUser for demonstration

                    User[] default_admin = { new AdminUser("admin", "admin") };

                    SaveJson(default_admin);

                    // Returning the default user
                    return default_admin;
                }
                return users;
            }
            catch
            {
                MessageBox.Show("Failed to load the file, creating a new file");

                // Creating a default AdminUser for demonstration
                User[] default_admin = { new AdminUser("admin", "admin") };

                SaveJson(default_admin);

                // Returning the default user
                return default_admin;
            }
        }

        public static void CreateNormal(string username, string password)
        {

            // Load users from JSON
            User[] all_users = LoadJson();

            // Create a new user (replace "newUser" with actual data)
            NormalUser new_user = new NormalUser(username, password);

            // Add the new user to the existing users array
            Array.Resize(ref all_users, all_users.Length + 1);
            all_users[all_users.Length - 1] = new_user;

            // Save the updated users array back to JSON
            SaveJson(all_users);

            MessageBox.Show("New accout has been created.");
        }

        public static void CreateGuest() 
        {
            User[] all_users = LoadJson();

            Guest new_user = new Guest();

            // Add the new user to the existing users array
            Array.Resize(ref all_users, all_users.Length + 1);
            all_users[all_users.Length - 1] = new_user;

            // Save the updated users array back to JSON
            SaveJson(all_users);

        }

        public static void ResetPassword(string username, string password)
        {
            User[] all_users = LoadJson();

            foreach (User user in all_users)
            {
                if (user.Username == username)
                {
                    user.Password = password;
                    SaveJson(all_users);
                    MessageBox.Show($"User: {username} password has been changed");
                }
            }
        }
        // Validate Password and Login
        public static bool PasswordLogin(string username, string password)
        {
            User[] all_users = LoadJson();

            foreach (User user in all_users)
            {
                if (user.Username == username & user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}