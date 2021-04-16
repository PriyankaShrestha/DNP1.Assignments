using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FileData;
using Models;

namespace Assignment2.Data.Interfaces
{
    public class FamilyService : IFamilyService
    {
        private HttpClient client;
        private string uri = "http://localhost:5006";

        public FamilyService()
        {
            client = new HttpClient();
        }

        public async Task AddFamilyAsync(Family family)
        {
            /*file.Families.Add(family);
            file.SaveChanges();
            return family;*/
            
            string serializedFamily = JsonSerializer.Serialize(family);

            StringContent content = new StringContent(
                serializedFamily,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync($"{uri}/families" , content);
        }

        public async Task RemoveFamilyAsync(string address)
        {
            /*Family familyToRemove = file.Families.First(t => t.Address().Equals(address));
            file.Families.Remove(familyToRemove);
            file.SaveChanges();*/
            
            await client.DeleteAsync($"{uri}/families/{address}");
        }

        public async Task UpdateFamilyAsync(string address, Family family)
        {
            /*Family toUpdate = file.Families.First(t => t.Address().Equals(family.Address()));
            toUpdate.City = family.City;
            toUpdate.StreetName = family.StreetName;
            toUpdate.HouseNumber = family.HouseNumber;
            toUpdate.Floor = family.Floor;
            
            file.SaveChanges();

            return toUpdate;*/
            
            string serializedFamily = JsonSerializer.Serialize(family, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            StringContent content = new StringContent(
                serializedFamily,
                Encoding.UTF8,
                "application/json"
            );

            await client.PatchAsync($"{uri}/families/{address}", content);
        }

        public async Task<Family> GetFamilyAsync(string address)
        {
            //return file.Families.FirstOrDefault(t => t.Address().Equals(address));
            
            Task<string> familyAsync = client.GetStringAsync(uri + $"/families/{address}");
            string message = await familyAsync;
            Family family =  JsonSerializer.Deserialize<Family>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return family;
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
           // return file.Families;
           
           Task<string> stringAsync = client.GetStringAsync(uri + $"/families");
           string message = await stringAsync;
           List<Family> result = JsonSerializer.Deserialize<List<Family>>(message, new JsonSerializerOptions
           {
               PropertyNameCaseInsensitive = true
           });
           return result;
        }
    }
}