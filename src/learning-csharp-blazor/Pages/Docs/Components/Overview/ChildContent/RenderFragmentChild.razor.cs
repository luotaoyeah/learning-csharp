using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.ChildContent
{
    /// <summary>
    /// RenderFragmentChild.
    /// </summary>
    public partial class RenderFragmentChild
    {
        /// <summary>
        /// 按照约定, <see cref="RenderFragment"/> 类型的参数必须名为 ChildContent.
        /// </summary>
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
