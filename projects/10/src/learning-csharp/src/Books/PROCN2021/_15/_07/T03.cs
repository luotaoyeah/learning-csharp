using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._07
{
    namespace _03
    {
        /// <summary>
        /// 15.7.3. configuration sources
        /// </summary>
        public class T03
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T03(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                IHost host = Host.CreateDefaultBuilder().ConfigureAppConfiguration(
                    (configurationBuilder) =>
                    {
                        configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
                        configurationBuilder.AddJsonFile("appsettings.luotao.json", optional: true, reloadOnChange: false);
                    }
                ).ConfigureServices(
                    (hostBuilderContext, serviceCollection) =>
                    {
                        IConfiguration configuration = hostBuilderContext.Configuration;
                        Assert.Equal("luotao", configuration.GetValue<string>("UserName"));
                    }
                ).Build();
            }
        }
    }
}
