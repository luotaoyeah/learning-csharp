using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindingWithComponentParameters
{
    /// <summary>
    /// ChildBind02.
    /// </summary>
    public partial class ChildBind02
    {
        /// <summary>
        /// 定义被绑定的属性.
        /// </summary>
        [Parameter]
        public int Year { get; set; }

        /// <summary>
        /// 定义被绑定的属性的变更事件, 按照约定, 该属性名命名规则为 {PARAMETER NAME}Changed.
        /// 如果我们不按照这个规则来命名, 则需要使用 @bind-Year:event="YearOtherChange" 来显式指定这个事件参数.
        /// </summary>
        [Parameter]
        public EventCallback<int> YearOtherChange { get; set; }

        private Task OnClick()
        {
            return YearOtherChange.InvokeAsync(2021);
        }
    }
}
