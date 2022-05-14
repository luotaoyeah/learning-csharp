using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._16._02
{
    namespace _00
    {
        /// <summary>
        /// 16.2. logging
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
                IHost host = Host.CreateDefaultBuilder().ConfigureLogging(
                    (hostBuilderContext, loggingBuilder) =>
                    {
                        loggingBuilder.ClearProviders();

                        loggingBuilder.AddConsole();
                        loggingBuilder.AddDebug();

                        if (OperatingSystem.IsWindows())
                        {
                            loggingBuilder.AddEventLog();
                        }
                    }
                ).ConfigureServices(
                    (hostBuilderContext, serviceCollection) => { serviceCollection.AddSingleton<TestService>(); }
                ).Build();

                TestService testService = host.Services.GetRequiredService<TestService>();
                testService.F01();
            }
        }
    }
}
