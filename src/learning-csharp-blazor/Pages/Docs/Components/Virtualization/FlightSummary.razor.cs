using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Virtualization
{
    /// <summary>
    /// FlightSummary.
    /// </summary>
    public partial class FlightSummary
    {
        /// <summary>
        /// Details.
        /// </summary>
        [Parameter]
        public string? Details { get; set; }
    }
}
