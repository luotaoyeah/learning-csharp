using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.ChildContent
{
    /// <summary>
    /// RenderFragmentChild.
    /// </summary>
    public partial class RenderFragmentChild
    {
        /// <summary>
        /// 如果只有一个 RenderFragment 类型的参数,则按照约定属性必须名为 ChildContent.
        /// 这样一来, 在父组件的模板中子组件标签中间的所有内容都会被赋值到这个参数.
        /// </summary>
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public RenderFragment? Header { get; set; }

        [Parameter]
        public RenderFragment? Footer { get; set; }
    }
}
