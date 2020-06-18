using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling.EventCallback
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0#eventcallback-1.
    /// </summary>
    [Route("/docs/components/event-handling/eventcallback")]
    public sealed partial class EventCallback
    {
        [Inject]
        private ILogger<EventCallback>? Logger { get; set; }

        private void OnClick(int value)
        {
            Logger?.LogInformation(value.ToString());
        }
    }
}
