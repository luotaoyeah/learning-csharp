using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Luotao.Blazor.Pages.Docs.Components.TemplatedComponents
{
    /// <summary>
    /// TableTemplate.
    /// </summary>
    /// <typeparam name="TItem">TItem.</typeparam>
    public partial class TableTemplate<TItem>
    {
        /// <summary>
        /// TableHeader.
        /// </summary>
        [Parameter]
        public RenderFragment? TableHeader { get; set; }

        /// <summary>
        /// TableHeader.
        /// </summary>
        [Parameter]
        public RenderFragment<TItem>? RowTemplate { get; set; }

        /// <summary>
        /// Items.
        /// </summary>
        [Parameter]
        public IReadOnlyList<TItem>? Items { get; set; }
    }
}
