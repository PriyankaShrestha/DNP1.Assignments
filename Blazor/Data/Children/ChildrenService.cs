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
    public class ChildrenService :IChildrenService
    {
        private HttpClient client;
        private string uri = "http://localhost:5006";

        public ChildrenService()
        {
            client = new HttpClient();
        }
        
        public async Task AddChildAsync(Child child, string address)
        {
            /*Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Children.Add(child);
            file.SaveChanges();
            return child;*/
            
            string serializedChild = JsonSerializer.Serialize(child);

            StringContent content = new StringContent(
                serializedChild,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync("http://localhost:5003/children", content);
        }

        public async Task RemoveChildAsync(Child child, string address)
        {
         /*   Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Children.Remove(child);
            file.SaveChanges();*/
         
         await client.DeleteAsync($"http://localhost:5003/children/{address}/{child}");
        }
        
        public async Task<IList<Child>> GetChildrenAsync(string address)
        {
           /* Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            return fam.Children;*/
           
           Task<string> stringAsync = client.GetStringAsync(uri + $"/children/{address}");
           string message = await stringAsync;
           List<Child> result = JsonSerializer.Deserialize<List<Child>>(message, new JsonSerializerOptions
           {
               PropertyNameCaseInsensitive = true
           });
           return result;
        }
    }
}