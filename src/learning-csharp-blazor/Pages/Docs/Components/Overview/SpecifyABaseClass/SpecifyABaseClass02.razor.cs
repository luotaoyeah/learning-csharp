using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.SpecifyABaseClass
{
    /// <summary>
    /// SpecifyABaseClass02.
    /// </summary>
    public partial class SpecifyABaseClass02 : SpecifyABaseClassBase
    {
        [Inject]
        private ILogger<SpecifyABaseClass02>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            Logger.LogInformation(SomeText);
        }
    }
}
