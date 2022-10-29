
using AutoMapper;

namespace Books.Api.Profiles;

public class BooksProfile : Profile
{
    public BooksProfile()
    {
        // CreateMap<Source, Destination>
        // Source --> Destination

        // Entities.Book --> Models.Book
        CreateMap<Entities.Book, Models.Book>()
            // tell it how to map to Models.Book.Author property
            .ForMember(
                dest => dest.Author,
                opt => opt.MapFrom(
                    src => $"{src.Author.FirstName} {src.Author.LastName}"
                )
            );

        // Models.CreateBookModel --> Entities.Book
        CreateMap<Models.CreateBookModel, Entities.Book>();
    }
}