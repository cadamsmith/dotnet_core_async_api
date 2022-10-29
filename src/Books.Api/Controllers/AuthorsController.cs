
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Books.Api.Models;
using Books.Api.Services;

namespace Books.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly IAuthorsRepository _authorsRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<AuthorsController> _logger;

    public AuthorsController(IAuthorsRepository authorsRepository, IMapper mapper, ILogger<AuthorsController> logger)
    {
        _authorsRepository = authorsRepository ?? throw new ArgumentNullException(nameof(authorsRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    public async Task<ActionResult<Author>> GetAuthor(Guid id)
    {
        var authorEntity = await _authorsRepository.GetAuthorAsync(id);

        if (authorEntity is null)
        {
            return NotFound();
        }

        var mappedAuthor = _mapper.Map<Author>(authorEntity);
        return Ok(mappedAuthor);
    }

    [HttpPost]
    public async Task<ActionResult<Author>> CreateAuthor([FromBody] CreateAuthorModel author)
    {
        var authorEntity = _mapper.Map<Entities.Author>(author);

        await _authorsRepository.SaveChangesAsync();

        // Re-fetch the author from the data store
        await _authorsRepository.GetAuthorAsync(authorEntity.Id);

        return CreatedAtAction(
            "GetAuthor",
            new { id = authorEntity.Id },
            _mapper.Map<Author>(authorEntity)
        );
    }
}