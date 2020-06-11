using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.AttributeSplattingAndArbitraryParameters
{
    /// <summary>
    /// AttributeSplattingAndArbitraryParameters01.
    /// </summary>
    public partial class AttributeSplattingAndArbitraryParameters01
    {
        /// <summary>
        /// X.
        /// </summary>
        [Parameter]
        public string? X { get; set; }

#pragma warning disable CA2227,S4004

        /// <summary>
        /// 所有未被其他 parameter 匹配的 attributes 都会一起打包放到这个 parameter 里面.
        /// 组件中最多只有一个 parameter 可以设置 Parameter(CaptureUnmatchedValues = true).
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? OtherParameters { get; set; }

#pragma warning restore CA2227,S4004
    }
}
