using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Routing
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-5.0#route-parameters.
    /// </summary>
    [Route("/docs/fundamentals/routing/route-parameters/{Name}/{Text?}")]
    public partial class RouteParameters
    {
        /// <summary>
        /// 路径参数.
        /// </summary>
        [Parameter]
        public string Name { get; set; }

        /// <summary>
        /// 可选的路径参数.
        /// </summary>
        [Parameter]
        public string? Text { get; set; }

        [Inject]
        private ILogger<RouteParameters> Logger { get; set; }

        /// <inheritdoc />
        protected override void OnInitialized()
        {
            Logger.LogInformation($"OnInitialized().Text: {Text}");
        }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            Logger.LogInformation($"OnParametersSet().Text: {Text}");
        }

        /// <inheritdoc />
        protected override void OnAfterRender(bool firstRender)
        {
            Logger.LogInformation($"OnAfterRender().firstRender: {firstRender.ToString()}");
        }
    }
}
