using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.CascadingValuesAndParameters.CascadingValueComponent
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/cascading-values-and-parameters?view=aspnetcore-5.0#cascadingvalue-component-1.
    /// </summary>
    [Route("/docs/components/cascading-values-and-parameters/cascadingvalue-component")]
    public partial class CascadingValueComponent
    {
        private readonly ThemeInfo themeInfo = new() { ButtonClass = "btn-primary" };
    }
}
