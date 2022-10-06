
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Api.Entities;

[Table("Authors")]
public class Author
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string LastName { get; set; } = string.Empty;
}
