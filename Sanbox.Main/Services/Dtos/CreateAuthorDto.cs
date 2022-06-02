using System.ComponentModel.DataAnnotations;
using Sanbox.Main.Domain;

namespace Sanbox.Main.Services.Dtos;

public class CreateAuthorDto
{
    [Required]
    [StringLength(AuthorConsts.MaxNameLength)]
    public string Name { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }
        
    public string ShortBio { get; set; }
}