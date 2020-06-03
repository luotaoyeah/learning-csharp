using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Rendering.RenderingConventionsForComponentbase
{
    /// <summary>
    /// Child02.
    /// </summary>
    public partial class Child02
    {
        /// <summary>
        /// 如果参数是引用类型, 则只要父组件触发 render, 该组件也会触发 render.
        /// </summary>
        [Parameter]
        public Person? Person { get; set; }

        [Inject]
        private ILogger<Child02>? Logger { get; set; }

        /// <inheritdoc/>
        public override Task SetParametersAsync(ParameterView parameters)
        {
            if (parameters.TryGetValue<Person>(nameof(Person), out _))
            {
                Logger.LogInformation($"{nameof(SetParametersAsync)}().{nameof(Person)}");
            }

            return base.SetParametersAsync(parameters);
        }

        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            Logger.LogInformation($"{nameof(OnAfterRender)}()");
        }
    }
}
