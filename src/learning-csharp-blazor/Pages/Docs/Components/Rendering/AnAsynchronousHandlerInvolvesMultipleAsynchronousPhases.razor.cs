using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Rendering
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/rendering?view=aspnetcore-5.0#an-asynchronous-handler-involves-multiple-asynchronous-phases.
    /// </summary>
    [Route("/docs/components/rendering/an-asynchronous-handler-involves-multiple-asynchronous-phases")]
    public partial class AnAsynchronousHandlerInvolvesMultipleAsynchronousPhases
    {
        private int currentCount;

        /// <summary>
        /// 如果一个异步的事件处理函数中, 包含多个异步操作,
        /// 则只有第一个异步(await)之前和最后一个异步(await)之后会自动触发 render, 其余需要手动触发.
        /// </summary>
        private async Task IncrementCount()
        {
            currentCount++;

            await Task.Delay(1000);
            currentCount++;
            StateHasChanged();

            await Task.Delay(1000);
            currentCount++;
            StateHasChanged();

            await Task.Delay(1000);
            currentCount++;
        }
    }
}
