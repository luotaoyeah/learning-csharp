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
        private string? value = DateTime.Now.ToString("HH:mm:ss.fff");

        /// <summary>
        /// 事件处理函数支持异步.
        /// </summary>
        private async Task OnClick()
        {
            await Task.Delay(1000);
            value = DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}
