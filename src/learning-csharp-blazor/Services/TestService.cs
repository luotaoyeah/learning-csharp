using Luotao.Blazor.Pages;
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
        /// TestService.
        /// </summary>
        /// <param name="_httpClient">_httpClient.</param>
        public TestService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        /// <summary>
        /// F01.
        /// </summary>
        /// <returns>随机数字.</returns>
        public int F01()
        {
            return new Random().Next(1, 9);
        }

        /// <summary>
        /// HTTP 请求.
        /// </summary>
        /// <returns>请求返回数据.</returns>
        public Task<FetchData.WeatherForecast[]?> F02()
        {
            return httpClient.GetFromJsonAsync<FetchData.WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
