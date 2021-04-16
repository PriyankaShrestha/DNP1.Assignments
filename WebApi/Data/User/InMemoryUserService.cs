using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Data
{
    public class InMemoryUserService :IUserService
    {
        private UserFile file;

        public InMemoryUserService(UserFile file)
        {
            this.file = file;
        }
        
        
        public async Task<User> AddUserAsync(User user)
        {
            file.Users.Add(user);
            file.SaveChanges();
            return user;
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User u = file.Users.FirstOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
            if (u != null)
            {
                return u;
            }
            throw new Exception("User not found");
        }

        public async Task<User> GetUserAsync(string username)
        {
            User first = file.Users.FirstOrDefault(user => user.Username.Equals(username));
            return first;
        }
    }
}