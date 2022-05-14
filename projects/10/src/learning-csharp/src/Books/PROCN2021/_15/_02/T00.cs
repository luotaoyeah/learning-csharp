using Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;
using Microsoft.Extensions.DependencyInjection;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._02
{
    namespace _00
    {
        /// <summary>
        /// 15.2. using the .NET DI container
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
                ServiceCollection serviceCollection = new ServiceCollection();
                serviceCollection.AddSingleton<IGreetingService, GreetingService>();
                serviceCollection.AddTransient<HomeController>();

                ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

                HomeController homeController = serviceProvider.GetRequiredService<HomeController>();

                testOutputHelper.WriteLine(homeController.Hello("luotao"));
            }
        }
    }
}
