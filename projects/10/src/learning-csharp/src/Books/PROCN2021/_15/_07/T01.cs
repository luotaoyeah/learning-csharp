using Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._07
{
    namespace _01
    {
        /// <summary>
        /// 15.7.1. using IConfiguration
        /// </summary>
        public class T01
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T01(ITestOutputHelper testOutputHelper)
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

                        Assert.Equal("value for Key1", configuration.GetValue<string>("Key1"));
                        Assert.Equal("value for Key1", configuration["Key1"]);

                        // 使用 : 分隔多级路径
                        Assert.Equal("value for key 3", configuration["SomeTypedConfig:Key3"]);

                        // GetSection() 获取子对象, 返回类型为 IConfigurationSection
                        Assert.Equal("value for key 3", configuration.GetSection("SomeTypedConfig").GetValue<string>("Key3"));
                        Assert.Equal("this is the connection string to a database", configuration.GetConnectionString("BooksConnection"));

                        // 如果 key 对应的值是一个 section, 而不是一个 value (即叶节点), 则 GetValue() 返回 null
                        Assert.Equal(null, configuration.GetValue<string>("SomeTypedConfig"));
                    }
                ).Build();
            }
        }
    }
}
