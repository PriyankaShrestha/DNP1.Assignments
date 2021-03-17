using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IPersonTarget
    {
        void AddFamily(Family family);
        void RemoveFamily(string address);
        void Update(Family family);
        Family Get(string address);
        IList<Family> Get();
        
        
        void AddNewAdult(Adult adult, string address);
        void RemoveAdult(Adult adult, string address);
        Adult GetAdult(int adultId, string address);
        void UpdateAdult(Adult adult, string address);
        
        
        void AddNewChild(Child child, string address);
        void RemoveChild(Child child, string address);
    }
}