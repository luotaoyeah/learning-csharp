using Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._03
{
    namespace _00
    {
        /// <summary>
        /// 15.3. using the Host class
        /// </summary>
        public class T00
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T00(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                IHost host = Host.CreateDefaultBuilder().ConfigureServices(
                    (services) =>
                    {
                        services.AddSingleton<IGreetingService, GreetingService>();
                        services.AddTransient<HomeController>();
                    }
                ).Build();

                HomeController homeController = host.Services.GetRequiredService<HomeController>();
                testOutputHelper.WriteLine(homeController.Hello("luotao"));
            }
        }
    }
}
