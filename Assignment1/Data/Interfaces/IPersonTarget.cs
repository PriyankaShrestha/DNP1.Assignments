using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IPersonTarget
    {
        void AddFamily(Family family);
        void RemoveFamily(int id);
        void Update(Family family);
        Family Get(int id);
        IList<Family> Get();
        
        void AddNewAdult(Adult adult, int id);
        void RemoveAdult(Adult adult, int id);
        Adult GetAdult(int adultId, int familyId);
        void UpdateAdult(Adult adult, int familyId);
        
        void AddNewChild(Child child, int id);
        void RemoveChild(Child child, int id);
    }
}