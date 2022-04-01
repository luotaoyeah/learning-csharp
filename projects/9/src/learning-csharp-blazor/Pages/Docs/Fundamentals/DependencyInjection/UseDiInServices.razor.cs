using Luotao.Blazor.Models;
using Luotao.Blazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.DependencyInjection
{
    /// <summary>
    /// sdf.
    /// </summary>
    [Route("/docs/fundamentals/dependency-injection/use-di-in-services")]
    public partial class UseDiInServices
    {
        private WeatherForecast[] weatherForecasts = Array.Empty<WeatherForecast>();

        [Inject]
        private ILogger<UseDiInServices> Logger { get; set; } = null!;

        [Inject]
        private ITestService TestService { get; set; } = null!;

        /// <inheritdoc/>
        protected override async Task OnInitializedAsync()
        {
            weatherForecasts = await TestService.GetWeatherForecastsAsync() ?? Array.Empty<WeatherForecast>();
            Logger.LogInformation(JsonSerializer.Serialize(weatherForecasts));
        }
    }
}
