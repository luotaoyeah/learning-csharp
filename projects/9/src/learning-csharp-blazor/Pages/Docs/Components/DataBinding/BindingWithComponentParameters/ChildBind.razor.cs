using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindingWithComponentParameters
{
    /// <summary>
    /// 自定义组件如何实现 @bind 双向绑定语法.
    /// </summary>
    public partial class ChildBind
    {
        /// <summary>
        /// 定义被绑定的属性.
        /// </summary>
        [Parameter]
        public int Year { get; set; }

        /// <summary>
        /// 定义被绑定的属性的变更事件, 按照约定, 该属性名命名规则为 {PARAMETER NAME}Changed.
        /// </summary>
        [Parameter]
        public EventCallback<int> YearChanged { get; set; }

        /// <summary>
        /// 调用 <see cref="EventCallback.InvokeAsync(object?)"/> 方法触发事件.
        /// </summary>
        private Task OnClick()
        {
            return YearChanged.InvokeAsync(2021);
        }
    }
}
