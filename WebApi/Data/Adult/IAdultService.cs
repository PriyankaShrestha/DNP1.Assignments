using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IAdultService
    {
        Task<Adult> AddAdultAsync(Adult adult, string address);
        Task RemoveAdultAsync(int cprNumber, string address);
        Task<Adult> GetAdultAsync(int adultId, string address);
        Task<Adult> UpdateAdultAsync(Adult adult, string address);
        Task<IList<Adult>> GetAdultsAsync(string address);
        Task<Job> AddJobAsync(Job job, string address, int id);
    }
}