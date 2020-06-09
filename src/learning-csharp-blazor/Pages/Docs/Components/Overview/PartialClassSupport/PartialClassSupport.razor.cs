using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.PartialClassSupport
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#partial-class-support.
    /// </summary>
    [Route("/docs/components/partial-class-support")]
    public partial class PartialClassSupport
    {
        private string? Text { get; set; }

        /// <summary>
        /// 使用 <see cref="InjectAttribute"/> 注入依赖.
        /// </summary>
        [Inject]
        private ILogger<PartialClassSupport>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            Text = "partial class approach";
            Logger?.LogInformation(Text);
        }
    }
}
