using Microsoft.AspNetCore.Components;
using System;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindAcrossMoreThanTwoComponents
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#bind-across-more-than-two-components-1.
    /// </summary>
    [Route("/docs/components/data-binding/bind-across-more-than-two-components")]
    public partial class BindAcrossMoreThanTwoComponents
    {
        private string? parentMessage = $"update from {nameof(BindAcrossMoreThanTwoComponents)}: {DateTime.Now:HH:mm:ss.fff}";

        private void OnClick()
        {
            parentMessage = $"update from {nameof(BindAcrossMoreThanTwoComponents)}: {DateTime.Now:HH:mm:ss.fff}";
        }
    }
}
