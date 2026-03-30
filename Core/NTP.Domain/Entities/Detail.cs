using NTP.Domain.Common;
using NTP.Domain.Common;

namespace NTP.Domain.Entities;

public class Detail : EntityBase
{
    public Detail()
    {

    }

    public Detail(string title, string value, int categoryId)
    {
        Title = title;
        Description = value;
        CategoryId = categoryId;
    }

    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int CategoryId { get; set; }
    public Category Category { get; set; }
}
