using Luotao.Blazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.DependencyInjection
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-5.0&pivots=webassembly#utility-base-component-classes-to-manage-a-di-scope.
    /// <para>
    /// 组件继承 <see cref="OwningComponentBase"/>, 然后通过它的 <see cref="OwningComponentBase.ScopedServices"/> 属性获取 service,
    /// 则这个 service 的生命周期跟组件一样, 在组件销毁时该 service 也会销毁.
    /// </para>
    /// </summary>
    [Route("/docs/fundamentals/dependency-injection/utility-base-component-classes-to-manage-a-di-scope")]
    public partial class UtilityBaseComponentClassesToManageADiScope : OwningComponentBase
    {
        private DisposableService? disposableService01;

        private ITestService? testService;

        /// <summary>
        /// 通过 [Inject] 或者 @inject 注入的 service 依然是 singleton 的.
        /// </summary>
        [Inject]
        private DisposableService? DisposableService02 { get; set; }

        protected override void OnInitialized()
        {
            // 通过 GetRequiredService() 获取的 service 是 component socpe 的.
            disposableService01 = ScopedServices.GetRequiredService<DisposableService>();
            testService = ScopedServices.GetRequiredService<ITestService>();
        }
    }
}
