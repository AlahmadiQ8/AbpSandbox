using AutoMapper;
using Sanbox.Main.Domain;
using Sanbox.Main.Services.Dtos;

namespace Sanbox.Main.Services;

public class ApplicationAutoMapperProfile : Profile
{
    public ApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        CreateMap<Author, AuthorDto>();
    }
}