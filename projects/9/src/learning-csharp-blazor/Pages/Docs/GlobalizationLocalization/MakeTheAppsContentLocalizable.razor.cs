using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Luotao.Blazor.Pages.Docs.GlobalizationLocalization
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-5.0#make-the-apps-content-localizable-2.
    /// </summary>
    [Route("/docs/aspnet/core/fundamentals/localization/make-the-apps-content-localizable-2")]
    public partial class MakeTheAppsContentLocalizable
    {
        private string? title;

        /// <summary>
        /// L.
        /// </summary>
        [Inject]
        public IStringLocalizer<MakeTheAppsContentLocalizable> L { get; set; } = null!;

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            title = L["Title"];
        }
    }
}
