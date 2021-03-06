using Microsoft.AspNetCore.Components;
using System;
using System.Timers;

namespace Luotao.Blazor.Pages.Docs.Components.WhenToUseKey
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#when-to-use-key.
    /// </summary>
    [Route("/docs/components/when-to-use-key")]
    public sealed partial class WhenToUseKey : IDisposable
    {
        private readonly Timer timer = new(1000);
        private string time = DateTime.Now.ToString("HH:mm:ss.fff");

        /// <inheritdoc/>
        public void Dispose() => timer.Dispose();

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            timer.Elapsed += OnElapsed;
            timer.Start();
        }

        private void OnElapsed(object sender, ElapsedEventArgs e)
        {
            InvokeAsync(() => time = DateTime.Now.ToString("HH:mm:ss.fff"));
            StateHasChanged();
        }
    }
}
