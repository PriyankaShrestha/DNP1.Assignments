using System.Threading.Tasks;
using FileData;

namespace Assignment2.Data.Users
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<User> ValidateUserAsync(string username, string password);
    }
}