
using Books.Api.Entities;

namespace Books.Api.Services;

public interface IAuthorsRepository
{
    Task<Author?> GetAuthorAsync(Guid id);

    void AddAuthor(Author author);

    Task<bool> SaveChangesAsync();

    IAsyncEnumerable<Author> GetAuthorsAsync();
}