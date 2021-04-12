using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IChildrenService
    {
        Task<Child> AddChildAsync(Child child, string address);
        Task RemoveChildAsync(Child child, string address);
        Task<IList<Child>> GetChildrenAsync(string address);
    }
}