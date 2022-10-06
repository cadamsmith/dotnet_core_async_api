
using Microsoft.EntityFrameworkCore;

using Books.Api.Contexts;
using Books.Api.Entities;

namespace Books.Api.Services;

public class BooksRepository : IBooksRepository
{
    private readonly BooksContext _context;
    private readonly ILogger<BooksRepository> _logger;

    public BooksRepository(BooksContext context, ILogger<BooksRepository> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<Book?> GetBookAsync(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException(nameof(id));
        }

        return await _context.Books.Include(b => b.Author)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public void AddBook(Book book)
    {
        if (book is null)
        {
            throw new ArgumentException(nameof(book));
        }

        _context.Add(book);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() > 0);
    }

    public IAsyncEnumerable<Book> GetBooksAsync()
    {
        return _context.Books.AsAsyncEnumerable();
    }
}