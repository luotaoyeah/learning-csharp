using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.Rendering
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/rendering?view=aspnetcore-5.0#suppress-ui-refreshing-shouldrender.
    /// </summary>
    [Route("/docs/components/rendering/suppress-ui-refreshing-shouldrender")]
    public partial class SuppressUiRefreshingShouldrender
    {
        private int x;

        [Inject]
        private ILogger<SuppressUiRefreshingShouldrender>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            Logger.LogInformation($"{nameof(OnAfterRender)}()");
        }

        /// <inheritdoc/>
        protected override bool ShouldRender()
        {
            return x % 5 == 0;
        }

        private void Increment()
        {
            x++;
        }
    }
}
