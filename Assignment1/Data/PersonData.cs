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
            int max;
            if (file.Families.Count == 0)
            {
                max = 1;
            }
            else
            {
                max = file.Families.Max(family => family.Id) + 1;
            }
            file.Families.Add(family);
            family.Id = max;
            file.SaveChanges();
        }

        public void RemoveFamily(int id)
        {
            Family familyToRemove = file.Families.First(t => t.Id == id);
            file.Families.Remove(familyToRemove);
            file.SaveChanges();
        }

        public void Update(Family family)
        {
            Family toUpdate = file.Families.First(t => t.Id == family.Id);
            toUpdate.City = family.City;
            toUpdate.StreetName = family.StreetName;
            toUpdate.HouseNumber = family.HouseNumber;
            toUpdate.Floor = family.Floor;
            
            file.SaveChanges();

        }

        public Family Get(int id)
        {
            return file.Families.FirstOrDefault(t => t.Id == id);
        }

        public IList<Family> Get()
        {
            return file.Families;
        }

        public void AddNewAdult(Adult adult, int id)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Id == id);
            fam.Adults.Add(adult);
            file.SaveChanges();
        }

        public void RemoveAdult(Adult adult, int id)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Id == id);
            fam.Adults.Remove(adult);
            file.SaveChanges();
        }

        public Adult GetAdult(int adultId, int familyId)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Id == familyId);
            Adult adult = fam.Adults.FirstOrDefault(a => a.CPRNumber == adultId);
            return adult;
        }

        public void UpdateAdult(Adult adult, int familyId)
        {
            Adult adu = GetAdult(adult.CPRNumber, familyId);
            adu.Age = adult.Age;
            adu.Weight = adult.Weight;
            adu.Height = adult.Height;
            adu.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            adu.JobTitle.Salary = adult.JobTitle.Salary;
            file.SaveChanges();
        }

        public void AddNewChild(Child child, int id)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Id == id);
            fam.Children.Add(child);
            file.SaveChanges();
        }

        public void RemoveChild(Child child, int id)
        {
            Family fam = file.Families.FirstOrDefault(t => t.Id == id);
            fam.Children.Remove(child);
            file.SaveChanges();
        }
    }
}