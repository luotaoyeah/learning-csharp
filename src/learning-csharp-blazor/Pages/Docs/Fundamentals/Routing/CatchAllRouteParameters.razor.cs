using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Routing
{
    /// <summary>
    /// <para>https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-5.0#catch-all-route-parameters.</para>
    /// <para>路径参数加上前缀 * 表示它会匹配剩下所有的路径段.</para>
    /// </summary>
    [Route("/docs/fundamentals/routing/catch-all-route-parameters/{*PageRoute}")]
    public partial class CatchAllRouteParameters
    {
        [Parameter]
        public string? PageRoute { get; set; }

        [Inject]
        private ILogger<CatchAllRouteParameters> Logger { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            Logger.LogInformation(PageRoute);
        }
    }
}
