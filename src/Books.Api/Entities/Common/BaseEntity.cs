
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Api.Entities.Common;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        CreatedAt = LastModifiedAt = DateTime.UtcNow;
        IsArchived = false;
    }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime LastModifiedAt { get; set; }

    public bool IsArchived { get; set; }
}