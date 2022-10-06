
using AutoMapper;

namespace Books.Api;

public class AuthorsProfile : Profile
{
    public AuthorsProfile()
    {
        // CreateMap<Source, Destination>
        // Source --> Destination

        // Entities.Author --> Models.Author
        CreateMap<Entities.Author, Models.Author>()
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")
            );

        CreateMap<Models.CreateAuthorModel, Entities.Author>();
    }
}