using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sanbox.Main.Domain;
using Sanbox.Main.Services;
using Sanbox.Main.Services.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Sanbox.Main.Pages.Authors;

public class CreateModal : BookStorePageModel
{
    private readonly IAuthorAppService _authorAppService;

    public CreateModal(IAuthorAppService authorAppService)
    {
        _authorAppService = authorAppService;
    }

    [BindProperty]
    public CreateAuthorViewModel Author { get; set; }
    
    public void OnGet()
    {
        Author = new CreateAuthorViewModel();
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateAuthorViewModel, CreateAuthorDto>(Author);
        await _authorAppService.CreateAsync(dto);
        return NoContent();
    }
    
    public class CreateAuthorViewModel
    {
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