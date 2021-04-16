using System.Transactions;

namespace WebApi.Models {
public class Adult : Person {
    public Job JobTitle { get; set; }

    public string ToString()
    {
        return base.ToString() + " " + JobTitle;
    }
}
}