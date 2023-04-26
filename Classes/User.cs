using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYildizi.Classes
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static List<User> LoadUsersFromFile(string filePath)
        {
            List<User> users = new List<User>();

            // Read the lines from the text file
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    User user = new User
                    {
                        Username = parts[0],
                        Password = parts[1]
                    };
                    users.Add(user);
                }

            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show($"Error reading file: {ex.Message}");
            }

            // Loop through each line and create a new User object

            return users;
        }
        public bool Authenticate(List<User> users)
        {
            foreach (User user in users)
            {
                if (Username == user.Username && Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }

}
