using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Routing
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-5.0#route-constraints.
    /// </summary>
    [Route("/docs/fundamentals/routing/route-constraints/{Id:int}")]
    public partial class RouteConstraints
    {
        /// <summary>
        /// 路径参数可以指定类型约束, 如果类型不匹配, 则路由就不会匹配.
        /// 因此两个路由可以地址一样, 只是路径参数类型不同.
        /// </summary>
        [Parameter]
        public int Id { get; set; }
    }
}
