using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Luotao.Blazor.Pages.Docs.Components.AttributeSplattingAndArbitraryParameters
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
        /// 没有被其他 parameter 匹配的 attributes 都会放到这个 parameter 里面.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? OtherParameters { get; set; }

#pragma warning restore CA2227,S4004
    }
}
