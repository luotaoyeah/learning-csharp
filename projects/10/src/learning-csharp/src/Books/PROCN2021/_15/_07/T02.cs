using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._07
{
    namespace _02
    {
        /// <summary>
        /// 15.7.2. reading strongly typed values
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                IHost host = Host.CreateDefaultBuilder().ConfigureServices(
                    (context, services) =>
                    {
                        IConfiguration configuration = context.Configuration;

                        SomeTypedConfig someTypedConfig = configuration.GetSection("SomeTypedConfig")
                            .Get<SomeTypedConfig>((options) => { options.BindNonPublicProperties = true; });

                        Assert.Equal("value for key 3", someTypedConfig.Key3);
                        Assert.Equal("value for key 4", someTypedConfig.Key4);
                        Assert.Equal("value for key 5", someTypedConfig.InnerConfig?.Key5);
                    }
                ).Build();
            }
        }
    }
}
