using Volo.Abp.Application.Dtos;

namespace Sanbox.Main.Services.Dtos;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}