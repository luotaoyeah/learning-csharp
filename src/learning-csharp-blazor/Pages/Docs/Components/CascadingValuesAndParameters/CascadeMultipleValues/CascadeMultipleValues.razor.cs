using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadeMultipleValues
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/cascading-values-and-parameters?view=aspnetcore-5.0#cascade-multiple-values.
    /// </summary>
    [Route("/docs/components/cascading-values-and-parameters/cascade-multiple-values")]
    public partial class CascadeMultipleValues
    {
        private readonly ThemeInfo themeInfoPrimary = new() { ButtonClass = "btn-primary" };
        private readonly ThemeInfo themeInfoSuccess = new() { ButtonClass = "btn-success" };
    }
}
