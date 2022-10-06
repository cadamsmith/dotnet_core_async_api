
using Books.Api.Entities;

namespace Books.Api.Services;

public interface IBooksRepository
{
    Task<Book?> GetBookAsync(Guid id);

    void AddBook(Book book);

    Task<bool> SaveChangesAsync();

    IAsyncEnumerable<Book> GetBooksAsync();
}