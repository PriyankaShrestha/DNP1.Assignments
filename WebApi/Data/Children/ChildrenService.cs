using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Data
{
    public class ChildrenService :IChildrenService
    {
        private FileContext file;

        public ChildrenService(FileContext file)
        {
            this.file = file;
        }
        
        public async Task<Child> AddChildAsync(Child child, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Children.Add(child);
            file.SaveChanges();
            return child;
        }

        public async Task RemoveChildAsync(Child child, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Children.Remove(child);
            file.SaveChanges();
        }
        
        public async Task<IList<Child>> GetChildrenAsync(string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            return fam.Children;
        }
    }
}