using Luotao.Blazor.Models;
using Luotao.Blazor.Services;
using Microsoft.AspNetCore.Components;
using System;

#pragma warning disable AsyncFixer03

namespace Luotao.Blazor.Pages.Docs.Components.Overview.InvokeComponentMethodsExternallyToUpdateState
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#invoke-component-methods-externally-to-update-state-1.
    /// </summary>
    [Route("/docs/components/invoke-component-methods-externally-to-update-state")]
    public sealed partial class InvokeComponentMethodsExternallyToUpdateState : IDisposable
    {
        private (string? key, int value) lastNotification;

        [Inject]
        private NotifierService? NotifierService { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            if (NotifierService != null)
            {
                NotifierService.Notify += OnNotify;
            }
        }

        /// <summary>
        /// <para>
        /// 如果某个事件是由组件外部触发的, 则回调函数里面的代码需要放到 <see cref="ComponentBase.InvokeAsync(Action)"/> 方法的回调函数里面执行,
        /// 这样才能保证代码是运行在 <see cref="System.Threading.SynchronizationContext"/> 中的.
        /// </para>
        /// <para>并且需要调用 <see cref="ComponentBase.StateHasChanged()"/> 方法通知组件重新渲染界面.</para>
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private async void OnNotify(object? sender, NotifyEventArgs e)
        {
            await InvokeAsync(
                () =>
                {
                    lastNotification = (key: e.Key ?? string.Empty, value: e.Value);
                    StateHasChanged();
                }
            );
        }

        private void OnClick()
        {
            NotifierService?.TriggerNotify("luotao", 18);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (NotifierService != null)
            {
                NotifierService.Notify -= OnNotify;
            }
        }
    }
}

#pragma warning restore AsyncFixer03
