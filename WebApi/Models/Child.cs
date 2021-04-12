using System.Collections.Generic;

namespace WebApi.Models {
public class Child : Person {
    
    public List<Interest> Interests { get; set; }
    public List<Pet> Pets { get; set; }
}
}