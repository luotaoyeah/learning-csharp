using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#cancelable-background-work.
    /// </summary>
    [Route("/docs/components/lifecycle/cancelable-background-work")]
    public sealed partial class CancelableBackgroundWork : IDisposable
    {
        private readonly CancellationTokenSource cancellationTokenSource = new();
        private bool canceled;
        private bool running;

        [Inject]
        private ILogger<CancelableBackgroundWork>? Logger { get; set; }

        /// <inheritdoc/>
        public void Dispose()
        {
            cancellationTokenSource.Dispose();
        }

        /// <summary>
        /// 开始一个异步任务.
        /// </summary>
        private async Task StartTask()
        {
            running = true;

            try
            {
                await Task.Delay(3000, cancellationTokenSource.Token);
            }
            catch (OperationCanceledException e)
            {
                canceled = true;
                Logger.LogInformation(e.Message);
                throw;
            }
            finally
            {
                running = false;
            }
        }

        /// <summary>
        /// 取消一个异步任务.
        /// </summary>
        private void CancelTask()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
