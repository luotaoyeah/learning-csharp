using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Configuration
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/configuration?view=aspnetcore-5.0#app-settings-configuration.
    /// </summary>
    [Route("/docs/fundamentals/configuration/app-settings-configuration")]
    public partial class AppSettingsConfiguration
    {
        [Inject]
        protected IConfiguration Configuration { get; set; }
    }
}
