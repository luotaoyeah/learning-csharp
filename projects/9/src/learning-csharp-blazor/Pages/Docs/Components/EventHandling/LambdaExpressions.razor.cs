using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-5.0#lambda-expressions-1.
    /// </summary>
    [Route("/docs/components/event-handling/lambda-expressions")]
    public sealed partial class LambdaExpressions
    {
        [Inject]
        private ILogger<LambdaExpressions> Logger { get; set; }

        private void OnClick(MouseEventArgs args, int i)
        {
            Logger.LogInformation($"{i.ToString()}: [{args.ClientX.ToString()}, {args.ClientY.ToString()}]");
        }
    }
}
