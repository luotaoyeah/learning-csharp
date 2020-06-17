using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

#pragma warning disable AsyncFixer01
namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindAcrossMoreThanTwoComponents
{
    /// <summary>
    /// NestedGrandChild.
    /// </summary>
    public partial class NestedGrandChild
    {
        [Parameter]
        public string GrandChildMessage { get; set; }

        [Parameter]
        public EventCallback<string> GrandchildMessageChanged { get; set; }

        private async Task OnClickAsync()
        {
            await GrandchildMessageChanged.InvokeAsync($"update from {nameof(NestedGrandChild)}: {DateTime.Now:HH:mm:ss.fff}");
        }
    }
}
#pragma warning restore AsyncFixer01
