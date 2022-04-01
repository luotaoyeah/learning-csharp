using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0#stop-event-propagation-1.
    /// </summary>
    [Route("/docs/components/event-handling/stop-event-propagation")]
    public sealed partial class StopPropagation
    {
        private bool stopPropagation;

        [Inject]
        private ILogger<StopPropagation> Logger { get; set; }

        private void OnParentClick()
        {
            Logger.LogInformation("PARENT");
        }

        private void OnChildClick()
        {
            Logger.LogInformation("CHILD");
        }
    }
}
