using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.Lifecycle
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-5.0#after-component-render-onafterrenderasync-1.
    /// </summary>
    [Route("/docs/components/lifecycle/after-component-render-onafterrenderasync")]
    public sealed partial class OnAfterRenderComponent
    {
        [Inject]
        private ILogger<OnAfterRenderComponent>? Logger { get; set; }

        /// <summary>
        /// <para>
        ///     除了 <see cref="OnAfterRender"/> 之外, 其他生命周期函数如果返回的是 task,
        ///     则返回的 task 完结之后, 又会触发一次渲染.
        /// </para>
        /// <para>
        ///     之所以 <see cref="OnAfterRender"/> 不会再次触发, 是为了避免死循环.
        /// </para>
        /// </summary>
        /// <returns>task.</returns>
        protected override Task OnInitializedAsync()
        {
            Logger.LogInformation($"{nameof(OnInitializedAsync)}()");
            return Task.Delay(1000);
        }

        /// <summary>
        /// 组件每次渲染完之后, 就会触发 <see cref="OnAfterRender"/>.
        /// </summary>
        /// <param name="firstRender">是否是首次渲染.</param>
        protected override void OnAfterRender(bool firstRender)
        {
            Logger.LogInformation($"{nameof(OnAfterRenderAsync)}(): {firstRender.ToString()}");
        }
    }
}
