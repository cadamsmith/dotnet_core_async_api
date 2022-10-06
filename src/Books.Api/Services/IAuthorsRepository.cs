
using Books.Api.Entities;

namespace Books.Api.Services;

public interface IAuthorsRepository
{
    Author? GetAuthor(Guid id);

    Task<Author?> GetAuthorAsync(Guid id);

    void AddAuthor(Author author);

    bool SaveChanges();

    Task<bool> SaveChangesAsync();

    IEnumerable<Author> GetAuthors();

    IAsyncEnumerable<Author> GetAuthorsAsync();
}