using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Routing
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-5.0#query-string-and-parse-parameters.
    /// </summary>
    [Route("/docs/fundamentals/routing/query-string-and-parse-parameters")]
    public partial class QueryStringAndParseParameters
    {
        [Inject]
        private ILogger<QueryStringAndParseParameters> Logger { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected string? Query { get; set; }

        /// <inheritdoc />
        protected override void OnInitialized()
        {
            // 解析 query 参数
            Query = new Uri(NavigationManager.Uri).Query;
        }
    }
}
