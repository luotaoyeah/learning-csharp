using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#unparsable-values.
    /// </summary>
    [Route("/docs/components/data-binding/unparsable-values")]
    public partial class UnparsableValues
    {
        /// <summary>
        /// 如果输入的值无法被转换为字段的类型, 则输入的值会被拒绝.
        /// </summary>
        private int? inputValue = 666;
    }
}
