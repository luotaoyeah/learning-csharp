using Luotao.Blazor.Models;
using System.Threading.Tasks;

namespace Luotao.Blazor.Services
{
    /// <summary>
    /// 测试服务.
    /// </summary>
    public interface ITestService
    {
        int F01();

        Task<WeatherForecast[]?> GetWeatherForecastsAsync();
    }
}
