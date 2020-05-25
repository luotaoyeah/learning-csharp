using Luotao.Blazor.Pages;
using System.Threading.Tasks;

namespace Luotao.Blazor.Services
{
    /// <summary>
    /// 测试服务.
    /// </summary>
    public interface ITestService
    {
        int F01();

        Task<FetchData.WeatherForecast[]?> F02();
    }
}
