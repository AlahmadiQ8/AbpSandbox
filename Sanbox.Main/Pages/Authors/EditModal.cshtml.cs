using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sanbox.Main.Domain;
using Sanbox.Main.Services;
using Sanbox.Main.Services.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Sanbox.Main.Pages.Authors;

public class EditModal : BookStorePageModel
{
    private readonly IAuthorAppService _authorAppService;
    
    [BindProperty]
    public EditAuthorViewModel Author { get; set; }

    public EditModal(IAuthorAppService authorAppService)
    {
        _authorAppService = authorAppService;
    }

    public async Task OnGet(Guid id)
    {
        var authorDto = await _authorAppService.GetAsync(id);
        Author = ObjectMapper.Map<AuthorDto, EditAuthorViewModel>(authorDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _authorAppService.UpdateAsync(
            Author.Id,
            ObjectMapper.Map<EditAuthorViewModel, UpdateAuthorDto>(Author)
        );

        return NoContent();
    }
    
    public class EditAuthorViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [StringLength(AuthorConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [TextArea]
        public string ShortBio { get; set; }
    }
}