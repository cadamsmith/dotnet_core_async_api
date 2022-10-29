
using Books.Api.Entities;

namespace Books.Api.Services;

public interface IBooksRepository
{
    Book? GetBook(Guid id);

    Task<Book?> GetBookAsync(Guid id);

    void CreateBook(Book book);

    bool SaveChanges();

    Task<bool> SaveChangesAsync();

    IEnumerable<Book> GetBooks();

    IAsyncEnumerable<Book> GetBooksAsync();
}