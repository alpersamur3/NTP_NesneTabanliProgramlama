using NTP.Domain.Common;
using NTP.Domain.Common;

namespace NTP.Domain.Entities;

public class Product : EntityBase
{
    public Product()
    {

    }

    public Product(string name, decimal price, string description)
    {

    }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    //public string ImageUrl { get; set; }
    public required string Description { get; set; }
    public ICollection<Category> Categories { get; set; }
}
