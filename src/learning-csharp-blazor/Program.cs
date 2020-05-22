using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
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
        public static Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            return builder.Build().RunAsync();
        }
    }
}
