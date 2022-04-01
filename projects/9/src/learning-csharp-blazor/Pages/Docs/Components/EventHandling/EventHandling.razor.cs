using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0.
    /// </summary>
    [Route("/docs/components/event-handling")]
    public sealed partial class EventHandling
    {
        private string? value = DateTime.Now.ToString("mm:ss");

        /// <summary>
        /// 事件处理函数支持异步函数.
        /// 事件处理函数执行完毕之后, 会自动触发界面渲染.
        /// </summary>
        private async Task OnClickAsync()
        {
            await Task.Delay(2000);
            value = DateTime.Now.ToString("mm:ss");
        }
    }
}
