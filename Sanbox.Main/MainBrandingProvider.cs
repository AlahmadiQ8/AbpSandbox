using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Sanbox.Main;

[Dependency(ReplaceServices = true)]
public class MainBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Main";
}
