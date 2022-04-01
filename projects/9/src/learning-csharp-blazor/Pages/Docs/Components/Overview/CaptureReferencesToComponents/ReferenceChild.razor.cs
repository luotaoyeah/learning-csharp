using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.CaptureReferencesToComponents
{
    /// <summary>
    /// ReferenceChild.
    /// </summary>
    public partial class ReferenceChild
    {
        [Inject]
        private ILogger<ReferenceChild>? Logger { get; set; }

        /// <summary>
        /// ChildMethod.
        /// </summary>
        /// <param name="value">value.</param>
        public void ChildMethod(int value)
        {
            Logger.LogInformation($"{nameof(ReferenceChild)}.{nameof(ChildMethod)}(): {value.ToString()}");
        }
    }
}
