using Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._06
{
    namespace _00
    {
        /// <summary>
        /// 15.6. using configuration files
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
                    (context, services) =>
                    {
                        IConfigurationSection greetingServiceConfiguration = context.Configuration.GetSection("GreetingService");
                        services.Configure<GreetingServiceOptions>(greetingServiceConfiguration);

                        services.AddSingleton<IGreetingService, GreetingService>();
                        services.AddSingleton<IGreetingService02, GreetingService02>();
                        services.AddTransient<HomeController>();
                    }
                ).Build();

                HomeController homeController = host.Services.GetRequiredService<HomeController>();

                testOutputHelper.WriteLine(homeController.F02("luotao"));
            }
        }
    }
}
