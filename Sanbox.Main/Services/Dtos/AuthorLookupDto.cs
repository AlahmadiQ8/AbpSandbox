using Volo.Abp.Application.Dtos;

namespace Sanbox.Main.Services.Dtos;

public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}