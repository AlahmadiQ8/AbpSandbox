using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sanbox.Main.Services;
using Sanbox.Main.Services.Dtos;

namespace Sanbox.Main.Pages.Books;

public class CreateModalModel : BookStorePageModel
{
    [BindProperty]
    public CreateUpdateBookDto Book { get; set; }
    
    private readonly IBookAppService _bookAppService;

    public CreateModalModel(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }
    
    public void OnGet()
    {
        Book = new CreateUpdateBookDto();
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _bookAppService.CreateAsync(Book);
        return NoContent();
    }
}