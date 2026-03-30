using NTP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Domain.Entities
{
    public class Detail:EntityBase
    {
        public Detail() { }

        public Detail(string title, string value, int categoryId)
        {
            Title = title;
            Value = value;
            CategoryId = categoryId;
        }

        public string Title { get; set; }
        public string Value { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
