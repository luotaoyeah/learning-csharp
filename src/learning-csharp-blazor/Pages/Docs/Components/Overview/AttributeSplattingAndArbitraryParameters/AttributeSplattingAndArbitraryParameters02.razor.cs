using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.AttributeSplattingAndArbitraryParameters
{
    /// <summary>
    /// AttributeSplattingAndArbitraryParameters02.
    /// </summary>
    public partial class AttributeSplattingAndArbitraryParameters02
    {
        /// <summary>
        /// X.
        /// </summary>
        [Parameter]
        public string? X { get; set; }

        /// <summary>
        /// Y.
        /// </summary>
        [Parameter]
        public string? Y { get; set; }

        /// <summary>
        /// Z.
        /// </summary>
        [Parameter]
        public string? Z { get; set; }
    }
}
