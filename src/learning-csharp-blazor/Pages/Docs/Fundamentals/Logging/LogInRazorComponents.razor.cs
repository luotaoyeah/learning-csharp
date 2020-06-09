using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Logging
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/logging?view=aspnetcore-5.0&pivots=webassembly#log-in-razor-components.
    /// </summary>
    [Route("/docs/fundamentals/logging/log-in-razor-components")]
    public partial class LogInRazorComponents
    {
        /// <summary>
        /// 组件中可以注入 <see cref="ILogger{TCategoryName}"/>.
        /// </summary>
        [Inject]
        private ILogger<LogInRazorComponents> Logger { get; set; }

        /// <summary>
        /// 组件中可以注入 <see cref="ILoggerFactory"/>.
        /// </summary>
        [Inject]
        private ILoggerFactory LoggerFactory { get; set; }

        protected override void OnInitialized()
        {
            Logger.LogTrace("LogTrace");
            Logger.LogDebug("LogDebug");
            Logger.LogInformation("LogInformation");
            Logger.LogWarning("LogWarning");
            Logger.LogError("LogError");

            LoggerFactory.CreateLogger<LogInRazorComponents>().LogInformation("ILoggerFactory");
        }
    }
}
