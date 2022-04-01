using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.Extensions.Logging;
using System;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.Routing
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-5.0#uri-and-navigation-state-helpers.
    /// </summary>
    [Route("/docs/fundamentals/routing/uri-and-navigation-state-helpers")]
    public sealed partial class UriAndNavigationStateHelpers : IDisposable
    {
        [Inject]
        private ILogger<UriAndNavigationStateHelpers> Logger { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        /// <inheritdoc />
        protected override void OnInitialized()
        {
            Logger.LogInformation(NavigationManager.BaseUri);
            Logger.LogInformation(NavigationManager.Uri);

            NavigationManager.LocationChanged += OnLocationChanged;
        }

        /// <summary>
        /// 跳转到 counter 页面.
        /// </summary>
        private void NavigateToCounterComponent()
        {
            NavigationManager.NavigateTo("/counter");
        }

        private void OnLocationChanged(object? sender, LocationChangedEventArgs eventArgs)
        {
            Logger.LogInformation(eventArgs.Location);

            // IsNavigationIntercepted 为 False 表示此次跳转是 NavigationManager.NavigateTo() 方法触发的,
            // 否则表示此次跳转是在浏览器触发的(比如点击某个链接)
            Logger.LogInformation(eventArgs.IsNavigationIntercepted.ToString());
        }

        /// <inheritdoc />
        public void Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;
        }
    }
}
