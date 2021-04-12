using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);
        Task<User> ValidateUserAsync(string username, string password);
        Task<User> GetUserAsync(string username);
    }
}