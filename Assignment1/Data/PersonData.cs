using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace Assignment1.Data
{
    public class PersonData : IPersonTarget
    {
       private FileContext file;

        public PersonData(FileContext file)
        {
            this.file = file;
        }
        
        public void AddFamily(Family family)
        {
            file.Families.Add(family);
            file.SaveChanges();
        }

        public void RemoveFamily(string address)
        {
            Family familyToRemove = file.Families.First(t => t.Address().Equals(address));
            file.Families.Remove(familyToRemove);
            file.SaveChanges();
        }

        public void Update(Family family)
        {
            Family toUpdate = file.Families.First(t => t.Address().Equals(family.Address()));
            toUpdate.City = family.City;
            toUpdate.StreetName = family.StreetName;
            toUpdate.HouseNumber = family.HouseNumber;
            toUpdate.Floor = family.Floor;
            
            file.SaveChanges();
        }

        public Family Get(string address)
        {
            return file.Families.FirstOrDefault(t => t.Address().Equals(address));
        }

        public IList<Family> Get()
        {
            return file.Families;
        }

        public void AddNewAdult(Adult adult, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Adults.Add(adult);
            file.SaveChanges();
        }

        public void RemoveAdult(Adult adult, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Adults.Remove(adult);
            file.SaveChanges();
        }

        public Adult GetAdult(int adultId, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            Adult adult = fam.Adults.FirstOrDefault(a => a.CPRNumber == adultId);
            return adult;
        }

        public void UpdateAdult(Adult adult, string address)
        {
            Adult adu = GetAdult(adult.CPRNumber, address);
            adu.Age = adult.Age;
            adu.Weight = adult.Weight;
            adu.Height = adult.Height;
            adu.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            adu.JobTitle.Salary = adult.JobTitle.Salary;
            file.SaveChanges();
        }

        public void AddNewChild(Child child, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Children.Add(child);
            file.SaveChanges();
        }

        public void RemoveChild(Child child, string address)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Address().Equals(address));
            fam.Children.Remove(child);
            file.SaveChanges();
        }
    }
}