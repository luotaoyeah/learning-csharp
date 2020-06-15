using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadingValueComponent
{
    /// <summary>
    /// Descendant.
    /// </summary>
    public partial class Descendant
    {
        /// <summary>
        /// 默认情况下 <see cref="CascadingParameterAttribute"/> 是根据类型来匹配 <see cref="CascadingValue{TValue}"/> 的.
        /// 如果多个 <see cref="CascadingValue{TValue}"/> 的类型相同, 则需要根据名称来匹配.
        /// </summary>
        [CascadingParameter]
        public ThemeInfo? ThemeInfo { get; set; }
    }
}
