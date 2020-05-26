using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.ComponentParameters
{
    /// <summary>
    /// ParameterChild.
    /// </summary>
    public partial class ParameterChild
    {
        /// <summary>
        /// Text.
        /// </summary>
        [Parameter]
        public string Text { get; set; } = "DEFAULT";

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
