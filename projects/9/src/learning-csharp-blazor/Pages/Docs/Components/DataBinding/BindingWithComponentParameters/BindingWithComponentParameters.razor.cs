using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindingWithComponentParameters
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#binding-with-component-parameters-1.
    /// </summary>
    [Route("/docs/components/data-binding/binding-with-component-parameters")]
    public partial class BindingWithComponentParameters
    {
        private int year = 2019;

        private void OnClick()
        {
            year = 2020;
        }
    }
}
