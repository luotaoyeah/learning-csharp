using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#component-initialization-oninitializedasync-1.
    /// </summary>
    [Route("/docs/components/lifecycle/component-initialization-oninitializedasync")]
    public sealed partial class OnInitializedComponent
    {
        public OnInitializedComponent()
        {
            Console.WriteLine($"{nameof(OnInitializedComponent)}()");
        }

        [Inject]
        private ILogger<OnInitializedComponent>? Logger { get; set; }

        protected override void OnInitialized()
        {
            Logger.LogInformation($"{nameof(OnInitialized)}()");
        }

        protected override Task OnInitializedAsync()
        {
            Logger.LogInformation($"{nameof(OnInitializedAsync)}()");
            return Task.CompletedTask;
        }

        protected override Task OnParametersSetAsync()
        {
            Logger.LogInformation($"{nameof(OnParametersSetAsync)}()");
            return Task.CompletedTask;
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            Logger.LogInformation($"{nameof(SetParametersAsync)}()");
            return base.SetParametersAsync(parameters);
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            Logger.LogInformation($"{nameof(OnAfterRenderAsync)}()");
            return Task.CompletedTask;
        }
    }
}
