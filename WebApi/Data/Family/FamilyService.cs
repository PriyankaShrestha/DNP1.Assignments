using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Data
{
    public class FamilyService : IFamilyService
    {
        private FileContext file;

        public FamilyService(FileContext file)
        {
            this.file = file;
        }

        public async Task<Family> AddFamilyAsync(Family family)
        {
            file.Families.Add(family);
            file.SaveChanges();
            return family;
        }

        public async Task RemoveFamilyAsync(string address)
        {
            Family familyToRemove = file.Families.First(t => t.Address().Equals(address));
            file.Families.Remove(familyToRemove);
            file.SaveChanges();
        }

        public async Task<Family> UpdateFamilyAsync(string address, Family family)
        {
            Family toUpdate = file.Families.First(t => t.Address().Equals(address));
            toUpdate.City = family.City;
            toUpdate.StreetName = family.StreetName;
            toUpdate.HouseNumber = family.HouseNumber;
            toUpdate.Floor = family.Floor;
            
            file.SaveChanges();

            return toUpdate;
        }

        public async Task<Family> GetFamilyAsync(string address)
        {
            return file.Families.FirstOrDefault(t => t.Address().Equals(address));
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            return file.Families;
        }
    }
}