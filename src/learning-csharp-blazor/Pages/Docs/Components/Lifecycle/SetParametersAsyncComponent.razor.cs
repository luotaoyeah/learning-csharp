using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#when-parameters-are-set-setparametersasync-1.
    /// </summary>
    [Route("/docs/components/lifecycle/when-parameters-are-set-setparametersasync/{Param?}")]
    public sealed partial class SetParametersAsyncComponent
    {
        /// <summary>
        /// constructor 执行之后, 首先进行依赖注入.
        /// </summary>
        public SetParametersAsyncComponent()
        {
            Console.WriteLine($"{nameof(SetParametersAsyncComponent)}()");
            Console.WriteLine($"Logger == null: {(Logger == null).ToString()}");
        }

        /// <summary>
        /// 参数.
        /// </summary>
        [Parameter]
        public string? Param { get; set; }

        [Inject]
        private ILogger<SetParametersAsyncComponent>? Logger { get; set; }

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

        /// <summary>
        /// 对参数的赋值过程进行拦截.
        /// </summary>
        /// <param name="parameters">本次传入的所有参数值.</param>
        /// <returns>task.</returns>
        public override Task SetParametersAsync(ParameterView parameters)
        {
            Console.WriteLine($"Logger == null: {(Logger == null).ToString()}");

            if (parameters.TryGetValue<string>(nameof(Param), out var value))
            {
                Logger.LogInformation($"parameters.Param: {value}");
            }

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
