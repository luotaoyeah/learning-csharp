using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#unparsable-values-1.
    /// </summary>
    [Route("/docs/components/data-binding/unparsable-values")]
    public partial class UnparsableValues
    {
        /// <summary>
        /// 如果输入的数据无法被转换为绑定的属性的类型,
        /// 则输入的值会被拒绝, 属性会恢复原来的值.
        /// </summary>
        private int? inputValue = 666;
    }
}
