using NTP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Domain.Entities
{
    public class Product:EntityBase
    {
        public Product() { 
            
        }

        public Product(string name, decimal price, string imageUrl, string description)
        {
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Description = description;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
