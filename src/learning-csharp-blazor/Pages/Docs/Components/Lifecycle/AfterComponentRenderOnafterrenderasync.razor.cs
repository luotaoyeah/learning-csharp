using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#after-component-render-onafterrenderasync.
    /// </summary>
    [Route("/docs/components/lifecycle/after-component-render-onafterrenderasync")]
    public sealed partial class AfterComponentRenderOnafterrenderasync
    {
        private readonly Stopwatch stopwatch = Stopwatch.StartNew();

        [Inject]
        private ILogger<AfterComponentRenderOnafterrenderasync>? Logger { get; set; }

        /// <inheritdoc/>
        protected override Task OnInitializedAsync()
        {
            Logger.LogInformation($"{nameof(OnInitializedAsync)}()");

            return SomeTask(nameof(OnInitializedAsync));
        }

        /// <summary>
        /// 除了 <see cref="OnAfterRender"/> 之外, 其他生命周期函数返回的 task 完结之后, 又会触发一次 render.
        /// </summary>
        /// <returns>task.</returns>
        protected override async Task OnParametersSetAsync()
        {
            Logger.LogInformation($"{nameof(OnParametersSetAsync)}()");

            await SomeTask(nameof(OnParametersSetAsync));

            await SomeTask(nameof(OnParametersSetAsync));
        }

        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            Logger.LogInformation($"{nameof(OnAfterRenderAsync)}(): {(stopwatch.ElapsedMilliseconds / 1000).ToString()}");
        }

        private async Task SomeTask(string message)
        {
            await Task.Delay(1000);
            Logger.LogInformation($"{message}.{nameof(SomeTask)}()");
        }
    }
}
