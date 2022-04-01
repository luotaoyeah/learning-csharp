using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Rendering.RenderingConventionsForComponentbase
{
    /// <summary>
    /// Child01.
    /// </summary>
    public partial class Child01
    {
        /// <summary>
        /// 如果所有的参数都是原始类型(int/string/DateTime...), 并且所有的参数值都没有变化, 则不会触发 render.
        /// </summary>
        [Parameter]
        public int X { get; set; }

        [Inject]
        private ILogger<Child01>? Logger { get; set; }

        /// <inheritdoc/>
        public override Task SetParametersAsync(ParameterView parameters)
        {
            if (parameters.TryGetValue<int>(nameof(X), out _))
            {
                Logger.LogInformation($"{nameof(SetParametersAsync)}().{nameof(X)}");
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
