using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IFamilyService
    {
        Task<Family> AddFamilyAsync(Family family);
        Task RemoveFamilyAsync(string address);
        Task<Family> UpdateFamilyAsync(string address, Family family);
        Task<Family> GetFamilyAsync(string address);
        Task<IList<Family>> GetFamiliesAsync();
    }
}