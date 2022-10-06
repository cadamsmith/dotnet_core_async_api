
using Books.Api.Models.Common;

namespace Books.Api.Models;

public class Book : BaseModel
{
    public string Author { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}