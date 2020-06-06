using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Luotao.Blazor.Pages.Docs.FormsValidation.ExampleForm
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-5.0#example-form.
    /// </summary>
    [Route("/docs/forms-validation/example-form")]
    public partial class ExampleForm
    {
        private readonly Starship starship = new();

        [Inject]
        private ILogger<ExampleForm>? Logger { get; set; }

        private void OnValidSubmit(EditContext editContext)
        {
            Logger.LogInformation(JsonSerializer.Serialize(editContext.Model, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void OnInvalidSubmit(EditContext editContext)
        {
            Logger.LogInformation(JsonSerializer.Serialize(editContext.Model, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
