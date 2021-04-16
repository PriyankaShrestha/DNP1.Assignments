using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment2.Data.Interfaces
{
    public interface IFamilyService
    {
        Task AddFamilyAsync(Family family);
        Task RemoveFamilyAsync(string address);
        Task UpdateFamilyAsync(string Address, Family family);
        Task<Family> GetFamilyAsync(string address);
        Task<IList<Family>> GetFamiliesAsync();
    }
}