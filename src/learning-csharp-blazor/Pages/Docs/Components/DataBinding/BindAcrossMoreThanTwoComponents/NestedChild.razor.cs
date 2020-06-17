using Microsoft.AspNetCore.Components;
using System;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding.BindAcrossMoreThanTwoComponents
{
    /// <summary>
    /// NestedChild.
    /// </summary>
    public partial class NestedChild
    {
        [Parameter]
        public string ChildMessage { get; set; }

        [Parameter]
        public EventCallback<string> ChildMessageChanged { get; set; }

        private string BoundValue
        {
            get => ChildMessage;
            set => ChildMessageChanged.InvokeAsync(value);
        }

        private void OnClick()
        {
            ChildMessage = $"update from {nameof(NestedChild)}: {DateTime.Now:HH:mm:ss.fff}";
        }
    }
}
