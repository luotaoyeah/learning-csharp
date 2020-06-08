using Luotao.Blazor.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Luotao.Blazor.Services
{
    /// <summary>
    /// 测试服务.
    /// </summary>
    public class TestService : ITestService
    {
        private readonly HttpClient httpClient;

        /// <summary>
        /// service 中需要使用 constructor injection 的方式来注入.
        /// </summary>
        /// <param name="httpClient">HttpClient.</param>
        public TestService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <summary>
        /// F01.
        /// </summary>
        /// <returns>一个随机整数.</returns>
        public int F01()
        {
            return new Random().Next(1, 9);
        }

        /// <summary>
        /// HTTP 请求.
        /// </summary>
        /// <returns>请求返回数据.</returns>
        public Task<WeatherForecast[]?> GetWeatherForecastsAsync()
        {
            return httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
