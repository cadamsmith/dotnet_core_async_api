
using Microsoft.EntityFrameworkCore;

using Books.Api.Contexts;
using Books.Api.Entities;

namespace Books.Api.Services;

/// <summary>
/// Handles data access for the Author entity
/// </summary>
public class AuthorsRepository : IAuthorsRepository
{
    private readonly BooksContext _context;
    private readonly ILogger<AuthorsRepository> _logger;

    public AuthorsRepository(BooksContext context, ILogger<AuthorsRepository> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Retrieves an author from context
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Author? GetAuthor(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return _context.Authors.FirstOrDefault(a => a.Id == id);
    }

    /// <summary>
    /// Retrieves an author from context asynchronously
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Author?> GetAuthorAsync(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return await _context.Authors.FirstOrDefaultAsync(a => a.Id == id);
    }

    /// <summary>
    /// Adds an author to the context
    /// </summary>
    /// <param name="author"></param>
    /// <remarks>
    /// this method does not need to be async, because the <c>_context.Add</c>
    /// operation is not io-bound
    /// </remarks>
    public void AddAuthor(Author author)
    {
        if (author is null)
        {
            throw new ArgumentNullException(nameof(author));
        }

        _context.Add(author);
    }

    /// <summary>
    /// Saves context, persisting changes
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
    /// retrieves all authors in context
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Author> GetAuthors()
    {
        return _context.Authors.AsEnumerable();
    }

    /// <summary>
    /// retrieves all authors in context as an async enumerable
    /// </summary>
    /// <returns></returns>
    public IAsyncEnumerable<Author> GetAuthorsAsync()
    {
        return _context.Authors.AsAsyncEnumerable();
    }
}
