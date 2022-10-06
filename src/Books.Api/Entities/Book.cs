
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Api.Entities;

[Table("Books")]
public class Book
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(2500)]
    public string Description { get; set; } = string.Empty;

    public Guid AuthorId { get; set; }

    public Author Author { get; set; } = null!;
}