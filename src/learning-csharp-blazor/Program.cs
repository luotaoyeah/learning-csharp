using Luotao.Blazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Luotao.Blazor
{
    /// <summary>
    /// Program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">args.</param>
        /// <returns>A <see cref="Task"/>representing the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            using var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            _ = builder.Services.AddScoped(_ => httpClient);

            // 加载自定义的配置文件
            using var response = await httpClient.GetAsync("mysettings.json");
            await using var readAsStreamAsync = await response.Content.ReadAsStreamAsync();
            _ = builder.Configuration.AddJsonStream(readAsStreamAsync);

            // 加载内存中(代码中)的配置数据
            var memoryConfig = new Dictionary<string, string> { { "Key03", "Value03" } };
            _ = builder.Configuration.Add(new MemoryConfigurationSource { InitialData = memoryConfig });

            // 注册服务
            _ = builder.Services.AddSingleton<NotifierService>();
            _ = builder.Services.AddScoped<ITestService, TestService>();
            _ = builder.Services.AddLocalization();
            _ = builder.Services.AddAntDesign();

            var host = builder.Build();
            var testService = host.Services.GetRequiredService<ITestService>();
            Console.WriteLine(testService.F01());

            var value03 = host.Configuration["Key03"];
            Console.WriteLine(value03);

            Console.WriteLine(builder.HostEnvironment.Environment);

            await host.RunAsync();
        }
    }
}
