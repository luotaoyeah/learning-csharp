using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;

namespace Luotao.Blazor.Pages.Docs.FormsValidation
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-5.0.
    /// </summary>
    [Route("/docs/forms-validation")]
    public partial class FormsValidation
    {
        private readonly ExampleModel exampleModel = new() { Name = "luotao" };
        private EditContext editContext;

        [Inject]
        private ILogger<FormsValidation>? Logger { get; set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            editContext = new EditContext(exampleModel);
        }

        private void OnValueSumit()
        {
            Logger.LogInformation("OnValueSumit");
        }
    }
}
