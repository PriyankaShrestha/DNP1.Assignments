using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Models {
public class Family {
    public string City { get; set; }
    public string Floor { get; set; }
    public string StreetName { get; set; }
    public int HouseNumber { get; set; }

    public string Address()
    {
        return City + StreetName + HouseNumber + Floor;
    }

    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    //public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();
        Children = new List<Child>();
    }
}


}