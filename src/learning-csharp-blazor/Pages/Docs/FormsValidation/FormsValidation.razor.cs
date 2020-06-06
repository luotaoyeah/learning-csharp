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

        private void OnValidSubmit()
        {
            Logger.LogInformation($"{nameof(OnValidSubmit)}()");
        }

        private void OnInvalidSubmit()
        {
            Logger.LogInformation($"{nameof(OnInvalidSubmit)}()");
        }

        /// <summary>
        /// <see cref="OnSubmit"/> 不能跟 <see cref="OnValidSubmit"/> 或者 <see cref="OnInvalidSubmit"/> 以前使用.
        /// </summary>
        /// <param name="editContext">editContext.</param>
        private void OnSubmit(EditContext editContext)
        {
            if (editContext.Validate())
            {
                Logger.LogInformation($"{nameof(OnSubmit)}()");
            }
            else
            {
                foreach (var validationMessage in editContext.GetValidationMessages())
                {
                    Logger.LogInformation(validationMessage);
                }
            }
        }
    }
}
