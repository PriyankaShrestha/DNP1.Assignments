using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Data
{
    public class AdultService : IAdultService
    {
        private FileContext file;

        public AdultService(FileContext file)
        {
            this.file = file;
        }

        public async Task<Adult> AddAdultAsync(Adult adult, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Adults.Add(adult);
            file.SaveChanges();
            return adult;
        }

        public async Task RemoveAdultAsync(Adult adult, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Adults.Remove(adult);
            file.SaveChanges();
        }

        public async Task<Adult> GetAdultAsync(int adultId, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            Adult adult = fam.Adults.FirstOrDefault(a => a.CPRNumber == adultId);
            return adult;
        }

        public async Task<Adult> UpdateAdultAsync(Adult adult, string address)
        {
            Adult adu = await GetAdultAsync(adult.CPRNumber, address);
            adu.Age = adult.Age;
            adu.Weight = adult.Weight;
            adu.Height = adult.Height;
            adu.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            adu.JobTitle.Salary = adult.JobTitle.Salary;
            file.SaveChanges();
            return adu;
        }

        public async Task<IList<Adult>> GetAdultsAsync(string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            return fam.Adults;
        }

        public async Task<Job> AddJobAsync(Job job, string address, int id)
        {
            Adult adu = await GetAdultAsync(id, address);
            adu.JobTitle = job;
            file.SaveChanges();
            return job;
        }
    }
}