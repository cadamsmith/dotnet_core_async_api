
using Microsoft.EntityFrameworkCore;

namespace Books.Api.Contexts;

public class BooksContext : DbContext
{
    public BooksContext(DbContextOptions<BooksContext> options) : base(options)
    {

    }
}