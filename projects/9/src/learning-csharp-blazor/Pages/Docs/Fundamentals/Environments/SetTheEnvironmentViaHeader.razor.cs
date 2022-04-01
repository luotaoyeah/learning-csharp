using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Environments
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/environments?view=aspnetcore-5.0#set-the-environment-via-header.
    /// </summary>
    [Route("/docs/fundamentals/environments/set-the-environment-via-header")]
    public partial class SetTheEnvironmentViaHeader
    {
        [Inject]
        private ILogger<SetTheEnvironmentViaHeader> Logger { get; set; }

        /// <summary>
        /// 在组件中注入 <see cref="IWebAssemblyHostEnvironment"/> 来读取 environment.
        /// </summary>
        [Inject]
        private IWebAssemblyHostEnvironment WebAssemblyHostEnvironment { get; set; }

        protected override void OnInitialized()
        {
            Logger.LogInformation(WebAssemblyHostEnvironment.Environment);
        }
    }
}
