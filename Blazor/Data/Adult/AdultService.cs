using System;
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
    public class AdultService : IAdultService
    {
        private HttpClient client;
        private string uri = "https://localhost:5005";

        public AdultService()
        {
            client = new HttpClient();
        }

        public async Task AddAdultAsync(Adult adult, string address)
        {
           /* Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Adults.Add(adult);
            file.SaveChanges();
            return adult;*/
           
           string serializedAdult = JsonSerializer.Serialize(adult);

           StringContent content = new StringContent(
               serializedAdult,
               Encoding.UTF8,
               "application/json"
           );

           await client.PostAsync($"{uri}/adults/{address}", content);
        }

        public async Task RemoveAdultAsync(Adult adult, string address)
        {
            /*Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Adults.Remove(adult);
            file.SaveChanges();*/
            
            await client.DeleteAsync($"{uri}/adults/{address}/{adult.CPRNumber}");
        }

        public async Task<Adult> GetAdultAsync(int adultId, string address)
        {
            /*Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            Adult adult = fam.Adults.FirstOrDefault(a => a.CPRNumber == adultId);
            return adult;*/
            
            Task<string> adultAsync = client.GetStringAsync(uri + $"/adults/{address}/{adultId}");
            string message = await adultAsync;
            Adult adult =  JsonSerializer.Deserialize<Adult>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return adult;
        }

        public async Task UpdateAdultAsync(Adult adult, string address)
        {
            /*Adult adu = await GetAdultAsync(adult.CPRNumber, address);
            adu.Age = adult.Age;
            adu.Weight = adult.Weight;
            adu.Height = adult.Height;
            adu.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            adu.JobTitle.Salary = adult.JobTitle.Salary;
            file.SaveChanges();
            return adu;*/
            
            string serializedAdult = JsonSerializer.Serialize(adult);

            StringContent content = new StringContent(
                serializedAdult,
                Encoding.UTF8,
                "application/json"
            );

            await client.PatchAsync($"{uri}/adults/{address}", content);
        }

        public async Task<IList<Adult>> GetAdultsAsync(string address)
        {
            /*Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            return fam.Adults;*/
/*
            Task<string> stringAsync = client.GetStringAsync($"{uri}/adults" + $"/{address}");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            Console.WriteLine(result);
            return result;*/

            HttpResponseMessage stringAsync =
                await client.GetAsync($"{uri}/adults/{address}");
            if (stringAsync.IsSuccessStatusCode)
            {
                string message = await stringAsync.Content.ReadAsStringAsync();
                List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return result;
            }
            throw new Exception("Adults not found");
        }

        public async Task AddJobAsync(Job job, string address, int id)
        {
            string serializedJob = JsonSerializer.Serialize(job);

            StringContent content = new StringContent(
                serializedJob,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync($"{uri}/adults/{address}/{id}", content);
        }
    }
}