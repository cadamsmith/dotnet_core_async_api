
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Books.Api.Entities.Common;

namespace Books.Api.Entities;

[Table("Authors")]
public class Author : BaseEntity
{
    [Required]
    [MaxLength(150)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string LastName { get; set; } = string.Empty;
}
