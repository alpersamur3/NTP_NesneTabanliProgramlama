using NTP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Domain.Entities
{
    public class Category:EntityBase
    {
        public Category() { 
            
        }

        public Category(string name, int subCategoryId, int sort)
        {
            Name = name;
            SubCategoryId = subCategoryId;
            Sort = sort;
        }

        public string Name { get; set; }
        public int SubCategoryId { get; set; }
        public int Sort { get; set; }
    }
   
}

