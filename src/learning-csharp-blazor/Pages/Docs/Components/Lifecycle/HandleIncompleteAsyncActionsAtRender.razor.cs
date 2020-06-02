using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#handle-incomplete-async-actions-at-render.
    /// </summary>
    [Route("/docs/components/lifecycle/handle-incomplete-async-actions-at-render")]
    public partial class HandleIncompleteAsyncActionsAtRender
    {
        private List<string> datas = new();
        private bool datasRetrieving;

        [Inject]
        private ILogger<HandleIncompleteAsyncActionsAtRender>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            Logger.LogInformation($"{nameof(OnAfterRender)}(): datasRetrieving = {datasRetrieving.ToString()}");
        }

        /// <inheritdoc/>
        protected override Task OnInitializedAsync()
        {
            return RetrieveDatas();
        }

        /// <summary>
        /// 获取数据.
        /// </summary>
        private async Task RetrieveDatas()
        {
            datasRetrieving = true;
            await Task.Delay(2000);
            datas = new List<string> { "1", "2", "3" };
            datasRetrieving = false;
        }

        private Task OnClickAsync()
        {
            return RetrieveDatas();
        }
    }
}
