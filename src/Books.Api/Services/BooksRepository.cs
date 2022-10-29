
using Microsoft.EntityFrameworkCore;

using Books.Api.Contexts;
using Books.Api.Entities;

namespace Books.Api.Services;

/// <summary>
/// Handles data access for the Book entity
/// </summary>
public class BooksRepository : IBooksRepository
{
    private readonly BooksContext _context;
    private readonly ILogger<BooksRepository> _logger;

    public BooksRepository(BooksContext context, ILogger<BooksRepository> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Retrieves a book from context
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Book? GetBook(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return _context.Books.Include(b => b.Author)
            .FirstOrDefault(b => b.Id == id);
    }

    /// <summary>
    /// Retrieves a book from context asynchronously
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Book?> GetBookAsync(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return await _context.Books.Include(b => b.Author)
            .FirstOrDefaultAsync(b => b.Id == id);
    }


    /// <summary>
    /// adds a book to the context
    /// </summary>
    /// <param name="book"></param>
    /// <remarks>
    /// this method does not need to be async, because the <c>_context.Add</c>
    /// operation is not io-bound
    /// </remarks>
    public void CreateBook(Book book)
    {
        if (book is null)
        {
            throw new ArgumentNullException(nameof(book));
        }

        _context.Add(book);
    }

    /// <summary>
    /// saves context, persisting changes
    /// </summary>
    /// <returns></returns>
    public bool SaveChanges()
    {
        return (_context.SaveChanges() > 0);
    }

    /// <summary>
    /// saves context asynchronously, persisting changes
    /// </summary>
    /// <returns></returns>
    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() > 0);
    }

    /// <summary>
    /// retrieves all books in context
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Book> GetBooks()
    {
        return _context.Books.AsEnumerable();
    }

    /// <summary>
    /// retrieves all books in context as an async enumerable
    /// </summary>
    /// <returns></returns>
    public IAsyncEnumerable<Book> GetBooksAsync()
    {
        return _context.Books.AsAsyncEnumerable();
    }
}
