using Luotao.Blazor.Shared;
using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Layouts.ApplyALayout
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/layouts?view=aspnetcore-5.0#apply-a-layout-1.
    ///
    /// <para>
    /// @layout 或者 <see cref="LayoutAttribute"/> 只能用于 route 组件,
    /// 非 route 组件如果需要指定 layout, 需要使用 <see cref="LayoutView"/> 组件.
    /// </para>
    ///
    /// </summary>
    [Layout(typeof(Layout01))]
    [Route("/docs/components/layouts/apply-a-layout")]
    public partial class ApplyALayout
    {
    }
}
