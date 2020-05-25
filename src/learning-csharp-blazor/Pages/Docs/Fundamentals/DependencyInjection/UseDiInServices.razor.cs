using Luotao.Blazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.DependencyInjection
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-3.1&pivots=webassembly#use-di-in-services.
    /// </summary>
    [Route("/docs/fundamentals/dependency-injection/use-di-in-services")]
    public partial class UseDiInServices
    {
        private FetchData.WeatherForecast[] weatherForecasts = Array.Empty<FetchData.WeatherForecast>();

        [Inject]
        private ILogger<UseDiInServices> Logger { get; set; } = null!;

        [Inject]
        private ITestService TestService { get; set; } = null!;

        /// <inheritdoc/>
        protected override async Task OnInitializedAsync()
        {
            weatherForecasts = await TestService.F02() ?? Array.Empty<FetchData.WeatherForecast>();
            Logger.LogInformation(JsonSerializer.Serialize(weatherForecasts));
        }
    }
}
