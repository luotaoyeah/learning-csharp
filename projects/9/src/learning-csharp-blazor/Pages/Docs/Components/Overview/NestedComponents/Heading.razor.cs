using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.NestedComponents
{
    /// <summary>
    /// Heading.
    /// </summary>
    [Route("/docs/components/nested-components/heading/{Name}")]
    public partial class Heading
    {
        [Parameter]
        public string? Name { get; set; }
    }
}
