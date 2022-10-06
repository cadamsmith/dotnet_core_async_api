
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Books.Api.Models;
using Books.Api.Services;

namespace Books.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBooksRepository _booksRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<BooksController> _logger;

    public BooksController(IBooksRepository booksRepository, IMapper mapper, ILogger<BooksController> logger)
    {
        _booksRepository = booksRepository ?? throw new ArgumentNullException(nameof(booksRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    public async Task<ActionResult<Book>> GetBook(Guid id)
    {
        var bookEntity = await _booksRepository.GetBookAsync(id);

        if (bookEntity is null)
        {
            return NotFound();
        }

        var mappedBook = _mapper.Map<Book>(bookEntity);
        return Ok(mappedBook);
    }

    [HttpPost]
    public async Task<ActionResult<Book>> CreateBook([FromBody] CreateBookModel book)
    {
        var bookEntity = _mapper.Map<Entities.Book>(book);
        _booksRepository.AddBook(bookEntity);

        await _booksRepository.SaveChangesAsync();

        // Fetch (refetch) the book from the data store, including the author
        await _booksRepository.GetBookAsync(bookEntity.Id);

        return CreatedAtRoute(
            "GetBook",
            new {id = bookEntity.Id},
            _mapper.Map<Book>(bookEntity)
        );
    }
}