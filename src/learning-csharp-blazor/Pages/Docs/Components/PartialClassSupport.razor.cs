using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#partial-class-support
    /// </summary>
    [Route("/docs/components/partial-class-support")]
    public partial class PartialClassSupport
    {
        private string? Text { get; set; }

        [Inject]
        private ILogger<PartialClassSupport>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            Text = "使用[Inject]注入";
            Logger?.LogInformation(Text);
        }
    }
}
