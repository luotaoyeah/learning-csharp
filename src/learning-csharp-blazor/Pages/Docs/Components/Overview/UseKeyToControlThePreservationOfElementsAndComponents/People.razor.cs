using System;
using System.Collections.Generic;
using System.Timers;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.UseKeyToControlThePreservationOfElementsAndComponents
{
    /// <summary>
    /// People.
    /// </summary>
    public sealed partial class People : IDisposable
    {
        private readonly List<Person> peoples = new()
        {
            new() { Data = DateTime.Now.ToString("HH:mm:ss") },
        };

        private readonly Timer timer = new(3000);

        /// <inheritdoc/>
        public void Dispose() => timer.Dispose();

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            timer.Elapsed += OnTimerCallback;
            timer.Start();
        }

        private async void OnTimerCallback(object? sender, ElapsedEventArgs e)
        {
            await InvokeAsync(
                () =>
                {
                    if (peoples.Count < 10)
                    {
                        peoples.Insert(0, new Person { Data = DateTime.Now.ToString("HH:mm:ss") });
                        StateHasChanged();
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            );
        }
    }
}
