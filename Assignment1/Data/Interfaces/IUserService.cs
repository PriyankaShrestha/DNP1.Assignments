using FileData;
using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        void AddUser(User user);
        User ValidateUser(string username, string password);
    }
}