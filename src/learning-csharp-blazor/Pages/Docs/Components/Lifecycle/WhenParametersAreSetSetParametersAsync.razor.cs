using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#when-parameters-are-set-setparametersasync.
    /// </summary>
    [Route("/docs/components/lifecycle/when-parameters-are-set-setparametersasync/{Param?}")]
    public sealed partial class WhenParametersAreSetSetParametersAsync
    {
        /// <summary>
        /// constructor 执行之后, 首先就会给注入的属性赋值.
        /// </summary>
        public WhenParametersAreSetSetParametersAsync()
        {
            Console.WriteLine($"Logger == null: {(Logger == null).ToString()}");
        }

        /// <summary>
        /// 示例参数.
        /// </summary>
        [Parameter]
        public string? Param { get; set; }

        [Inject]
        private ILogger<WhenParametersAreSetSetParametersAsync>? Logger { get; set; }

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
                Logger.LogInformation($"Param: {value}");
            }

            return base.SetParametersAsync(parameters);
        }
    }
}
