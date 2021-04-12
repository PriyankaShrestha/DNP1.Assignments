using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApi.Models;

namespace WebApi.Persistence
{
    public class UserFile
    {
        public IList<User> Users { get; private set; }
        private readonly string userFile = "users.json";

        public UserFile()
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