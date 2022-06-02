using Sanbox.Main.Localization;
using Volo.Abp.Application.Services;

namespace Sanbox.Main.Services;

public abstract class MainAppService : ApplicationService
{
    protected MainAppService()
    {
        LocalizationResource = typeof(MainResource);
    }
}