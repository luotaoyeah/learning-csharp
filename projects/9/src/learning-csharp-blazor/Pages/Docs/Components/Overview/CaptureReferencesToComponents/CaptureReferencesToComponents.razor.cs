using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.CaptureReferencesToComponents
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#capture-references-to-components-1.
    /// </summary>
    [Route("/docs/components/capture-references-to-components")]
    public partial class CaptureReferencesToComponents
    {
        private ReferenceChild? referenceChild;

        [Inject]
        private ILogger<CaptureReferencesToComponents>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            Logger.LogInformation($"referenceChild == null: {(referenceChild == null).ToString()}");
        }

        /// <summary>
        /// 组件第一次 render 之后, 才能拿到对子组件的引用.
        /// </summary>
        /// <param name="firstRender">首次渲染.</param>
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Logger.LogInformation($"referenceChild == null: {(referenceChild == null).ToString()}");
            }
        }

        /// <summary>
        /// 点击按钮.
        /// </summary>
        private void OnClick02()
        {
            referenceChild?.ChildMethod(222);
        }
    }
}
