using Microsoft.AspNetCore.Components;

#pragma warning disable S2933
namespace Luotao.Blazor.Pages.Docs.Components.DataBinding
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#binding-select-element-options-to-c-object-null-values-1.
    /// </summary>
    [Route("/docs/components/data-binding/binding-select-element-options-to-c-object-null-values")]
    public partial class BindingSelectElementOptionsToCObjectNullValues
    {
        private int? inputValue;

        private int? optionValue01 = 1;

        private string? optionValue02 = "2";
    }
}
#pragma warning restore S2933
