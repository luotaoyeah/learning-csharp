using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadingValueComponent
{
    /// <summary>
    /// Descendant.
    /// </summary>
    public partial class Descendant
    {
        /// <summary>
        /// 默认情况下 <see cref="CascadingParameterAttribute"/> 是根据类型来匹配 <see cref="CascadingValue{TValue}"/> 的,
        /// 根据类型来查找离我最近的那个 <see cref="CascadingValue{TValue}"/>.
        /// </summary>
        [CascadingParameter]
        public ThemeInfo? ThemeInfo { get; set; }
    }
}
