
namespace Books.Api.Models.Common;

public abstract class BaseModel
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime LastModifiedAt { get; set; }

    public bool IsArchived { get; set; }
}