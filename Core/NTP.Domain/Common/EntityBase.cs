using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Domain.Common
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
