using Luotao.Blazor.Services;
using Microsoft.AspNetCore.Components;
using System;

#pragma warning disable AsyncFixer03

namespace Luotao.Blazor.Pages.Docs.Components.Overview.InvokeComponentMethodsExternallyToUpdateState
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#invoke-component-methods-externally-to-update-state.
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
                NotifierService.NotifyEvent += OnNotifyEvent;
            }
        }

        private async void OnNotifyEvent(object? sender, NotifyEventArgs e)
        {
            await InvokeAsync(() => lastNotification = (key: e.Key ?? string.Empty, value: e.Value));
            StateHasChanged();
        }

        private void OnClick()
        {
            NotifierService?.Update("luotao", 18);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (NotifierService != null)
            {
                NotifierService.NotifyEvent -= OnNotifyEvent;
            }
        }
    }
}

#pragma warning restore AsyncFixer03
