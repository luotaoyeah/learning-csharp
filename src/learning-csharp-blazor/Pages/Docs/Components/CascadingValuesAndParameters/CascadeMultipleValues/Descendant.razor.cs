using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadeMultipleValues
{
    /// <summary>
    /// Descendant.
    /// </summary>
    public partial class Descendant
    {
        /// <summary>
        /// ThemeInfoSuccess.
        /// </summary>
        [CascadingParameter(Name = "success")]
        public ThemeInfo? ThemeInfoSuccess { get; set; }

        /// <summary>
        /// ThemeInfoPrimary.
        /// </summary>
        [CascadingParameter(Name = "primary")]
        public ThemeInfo? ThemeInfoPrimary { get; set; }
    }
}
