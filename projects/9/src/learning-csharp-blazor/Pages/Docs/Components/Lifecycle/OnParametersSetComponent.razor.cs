using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// <para>https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#after-parameters-are-set-onparameterssetasync-1.</para>
    ///
    /// <para>可以添加多个 <see cref="RouteAttribute"/>.</para>
    /// </summary>
    [Route("/docs/components/lifecycle/after-parameters-are-set-onparameterssetasync")]
    [Route("/docs/components/lifecycle/after-parameters-are-set-onparameterssetasync/{StartDate:datetime}")]
    public sealed partial class OnParametersSetComponent
    {
        [Parameter]
        public DateTime StartDate { get; set; }

        [Inject]
        private ILogger<OnParametersSetComponent> Logger { get; set; }

        protected override void OnParametersSet()
        {
            Logger.LogInformation($"{nameof(OnParametersSet)}(): {StartDate:yyyy-MM-dd HH:mm:ss}");

            if (StartDate == default)
            {
                StartDate = DateTime.Now;
            }
        }
    }
}
