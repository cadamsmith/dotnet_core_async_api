
using Books.Api.Models.Common;

namespace Books.Api.Models;

public class Author : BaseModel
{
    public string Name { get; set; } = string.Empty;
}