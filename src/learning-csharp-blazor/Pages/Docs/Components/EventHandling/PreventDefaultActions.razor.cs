using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0#prevent-default-actions-1.
    /// </summary>
    [Route("/docs/components/event-handling/prevent-default-actions")]
    public sealed partial class PreventDefaultActions
    {
        private int count;

        private void KeyHandler(KeyboardEventArgs obj)
        {
            if (obj.Key == "+")
            {
                count++;
            }
        }
    }
}
