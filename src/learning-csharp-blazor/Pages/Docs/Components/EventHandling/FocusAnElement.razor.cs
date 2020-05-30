using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0#focus-an-element.
    /// </summary>
    [Route("/docs/components/event-handling/focus-an-element")]
    public sealed partial class FocusAnElement
    {
        private ElementReference inputEl;

        private void OnClick()
        {
            _ = inputEl.FocusAsync();
        }
    }
}
