using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FileData;
using Models;

namespace Assignment1.Data
{
    public class InMemoryUserService : IUserService
    {
        private IList<User> Users;
        private readonly string userFile = "users.json";

        public InMemoryUserService()
        {
            Users = File.Exists(userFile) ? ReadData<User>(userFile) : new List<User>();
        }
        
        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
        public void AddUser(User user)
        {
            Users.Add(user);
            SaveChanges();
        }

        public User ValidateUser(string username, string password)
        {
            User first = Users.FirstOrDefault(user => user.Username.Equals(username));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
        
        public void SaveChanges()
        {
            string jsonUser = JsonSerializer.Serialize(Users, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(userFile, false))
            {
                outputFile.Write(jsonUser);
            }
        }
    }
}