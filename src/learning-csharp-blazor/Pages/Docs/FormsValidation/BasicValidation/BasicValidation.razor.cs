using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;
using System;

namespace Luotao.Blazor.Pages.Docs.FormsValidation.BasicValidation
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-5.0#basic-validation.
    /// </summary>
    [Route("/docs/forms-validation/basic-validation")]
    public sealed partial class BasicValidation : IDisposable
    {
        private readonly Holodeck holodeck = new();
        private EditContext? editContext;
        private ValidationMessageStore? validationMessageStore;

        [Inject]
        private ILogger<BasicValidation>? Logger { get; set; }

        protected override void OnInitialized()
        {
            editContext = new(holodeck);
            editContext.OnValidationRequested += OnValidationRequested;
            validationMessageStore = new(editContext);
        }

        private void OnValidationRequested(object? sender, ValidationRequestedEventArgs e)
        {
            Logger.LogInformation($"{nameof(OnValidationRequested)}()");

            validationMessageStore?.Clear();

            if (holodeck.Type1 == null)
            {
                holodeck.Type1 = string.Empty;
                validationMessageStore?.Add(() => holodeck.Type1, "不能为空");
            }
            else if (holodeck.Type1.Length < 3)
            {
                validationMessageStore?.Add(() => holodeck.Type1, "最小长度为3");
            }
        }

        private void OnValidSubmit()
        {
            Logger.LogInformation($"{nameof(OnValidSubmit)}:{holodeck.Type1}");
        }

        private void OnInvalidSubmit()
        {
            Logger.LogInformation($"{nameof(OnInvalidSubmit)}:{holodeck.Type1}");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (editContext != null)
            {
                editContext.OnValidationRequested -= OnValidationRequested;
            }
        }
    }
}
