
using Microsoft.EntityFrameworkCore;

using Books.Api.Contexts;
using Books.Api.Entities;

namespace Books.Api.Services;

public class AuthorsRepository : IAuthorsRepository
{
    private readonly BooksContext _context;
    private readonly ILogger<AuthorsRepository> _logger;

    public AuthorsRepository(BooksContext context, ILogger<AuthorsRepository> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(context));
    }

    public Author? GetAuthor(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return _context.Authors.FirstOrDefault(a => a.Id == id);
    }

    public async Task<Author?> GetAuthorAsync(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return await _context.Authors.FirstOrDefaultAsync(a => a.Id == id);
    }

    public void AddAuthor(Author author)
    {
        if (author is null)
        {
            throw new ArgumentNullException(nameof(author));
        }

        _context.Add(author);
    }

    public bool SaveChanges()
    {
        return (_context.SaveChanges() > 0);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() > 0);
    }

    public IEnumerable<Author> GetAuthors()
    {
        return _context.Authors.AsEnumerable();
    }

    public IAsyncEnumerable<Author> GetAuthorsAsync()
    {
        return _context.Authors.AsAsyncEnumerable();
    }
}
