using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#route-parameters.
    /// </summary>
    [Route("/docs/components/route-parameters/{Name}/{Age:int}")]
    public partial class RouteParameters
    {
        /// <summary>
        /// 姓名.
        /// </summary>
        [Parameter]
        public string Name { get; set; } = null!;

        /// <summary>
        /// 年龄.
        /// </summary>
        [Parameter]
        public int Age { get; set; }
    }
}
