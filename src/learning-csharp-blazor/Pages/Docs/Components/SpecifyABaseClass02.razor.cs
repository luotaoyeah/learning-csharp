using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#specify-a-base-class.
    /// </summary>
    [Route("/docs/components/specify-a-base-class/02")]
    public partial class SpecifyABaseClass02 : SpecifyABaseClassBase
    {
        [Inject]
        private ILogger<SpecifyABaseClass02>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            Logger.LogInformation(Text);
        }
    }
}
