using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.ComponentParameters
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#component-parameters.
    /// </summary>
    [Route("/docs/components/component-parameters")]
    public partial class ComponentParameters
    {
        /// <summary>
        /// Name.
        /// </summary>
        protected string Name { get; set; } = "luotao";
    }
}
