using Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadingValueComponent;
using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadeMultipleValues
{
    /// <summary>
    /// Descendant.
    /// </summary>
    public partial class Descendant
    {
        /// <summary>
        ///
        /// <para>
        /// 如果组件树上有多个类型相同的 <see cref="CascadingValue{TValue}"/>,
        /// 如果使用默认的策略(即根据类型来匹配离我最近的), 就无法获取更远的, 此时需要使用名称来匹配离我最近的.
        /// </para>
        ///
        /// <para>
        /// 如果有多个类型和名称都相同的 <see cref="CascadingValue{TValue}"/>, 则只能获取最近的那个.
        /// </para>
        ///
        /// </summary>
        [CascadingParameter(Name = "success")]
        public ThemeInfo? ThemeInfoSuccess { get; set; }

        /// <summary>
        /// ThemeInfoPrimary.
        /// </summary>
        [CascadingParameter(Name = "primary")]
        public ThemeInfo? ThemeInfoPrimary { get; set; }
    }
}
