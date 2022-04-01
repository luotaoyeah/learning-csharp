using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.ComponentParameters
{
    /// <summary>
    /// ParameterChild.
    /// </summary>
    public partial class ParameterChild
    {
        /// <summary>
        /// <para>如果父组件不传该参数, 则它会使用默认值.</para>
        /// <para>父组件有可能会传一个 null.</para>
        /// </summary>
        [Parameter]
        public string? Text { get; set; } = "DEFAULT";

        /// <summary>
        /// PanelBody.
        /// </summary>
        [Parameter]
        public PanelBody? PanelBody { get; set; }

        [Inject]
        private ILogger<ParameterChild>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            Logger?.LogInformation(Text);
        }
    }
}
