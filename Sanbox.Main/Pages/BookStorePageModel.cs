using Sanbox.Main.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sanbox.Main.Pages;

public abstract class BookStorePageModel : AbpPageModel
{
    protected BookStorePageModel()
    {
        LocalizationResourceType = typeof(MainResource);
    }
}