using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FileData;

namespace Assignment2.Data.Users
{
    public class InMemoryUserService : IUserService
    {
        private HttpClient client;
        private string uri = "http://localhost:5006";

        public InMemoryUserService()
        {
            client = new HttpClient();
        }
        
        public async Task AddUserAsync(User user)
        {
            /*Users.Add(user);
            SaveChanges();
            return user;*/
            
           string serializedUser = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(
                serializedUser,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync(uri + "/users", content);
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            HttpResponseMessage userAsync =
                await client.GetAsync(uri + $"/users?username={username}&password={password}");
            if (userAsync.IsSuccessStatusCode)
            {
                string userAsJson = await userAsync.Content.ReadAsStringAsync();
                User first = JsonSerializer.Deserialize<User>(userAsJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                Console.WriteLine(first);
                return first;
            }
            throw new Exception("User Not Found");
        }
        
        
    }
}