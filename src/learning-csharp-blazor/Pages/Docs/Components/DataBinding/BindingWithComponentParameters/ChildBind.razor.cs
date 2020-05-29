using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindingWithComponentParameters
{
    /// <summary>
    /// 自己写的组件如何实现 @bind 双向绑定语法.
    /// </summary>
    public partial class ChildBind
    {
        /// <summary>
        /// 年.
        /// </summary>
        [Parameter]
        public int Year { get; set; }

        /// <summary>
        /// YearChanged.
        /// </summary>
        [Parameter]
        public EventCallback<int> YearChanged { get; set; }

        private Task OnClick()
        {
            return YearChanged.InvokeAsync(2021);
        }
    }
}
