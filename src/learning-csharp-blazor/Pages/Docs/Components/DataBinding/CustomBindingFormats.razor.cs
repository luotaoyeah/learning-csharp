using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#custom-binding-formats.
    /// </summary>
    [Route("/docs/components/data-binding/custom-binding-formats")]
    public partial class CustomBindingFormats
    {
        private string? inputValue;

        private string? InputValue
        {
            get => inputValue;
            set => inputValue = value?.ToUpper();
        }
    }
}
