using AutoMapper;
using Sanbox.Main.Domain;
using Sanbox.Main.Services.Dtos;

namespace Sanbox.Main.ObjectMapping;

public class MainAutoMapperProfile : Profile
{
    public MainAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        CreateMap<Author, AuthorDto>();
        CreateMap<Pages.Authors.CreateModal.CreateAuthorViewModel, CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModal.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModal.EditAuthorViewModel, UpdateAuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
        
        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, Pages.Books.EditModalModel.EditBookViewModel>();
        CreateMap<Pages.Books.EditModalModel.EditBookViewModel, CreateUpdateBookDto>();
    }
}
