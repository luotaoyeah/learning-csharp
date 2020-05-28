using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadingValueComponent
{
    /// <summary>
    /// Descendant.
    /// </summary>
    public partial class Descendant
    {
        /// <summary>
        /// ThemeInfo.
        /// </summary>
        [CascadingParameter]
        public ThemeInfo? ThemeInfo { get; set; }
    }
}
