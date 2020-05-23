using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
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
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            using var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            _ = builder.Services.AddScoped(_ => httpClient);

            using var response = await httpClient.GetAsync("mysettings.json");
            using var readAsStreamAsync = await response.Content.ReadAsStreamAsync();
            builder.Configuration.AddJsonStream(readAsStreamAsync);

            await builder.Build().RunAsync();
        }
    }
}
