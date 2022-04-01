using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Luotao.Blazor.Pages.Docs.Components.EventHandling.EventCallback
{
    /// <summary>
    /// Child.
    /// </summary>
    public sealed partial class Child
    {
        /// <summary>
        /// 自定义的事件.
        /// </summary>
        [Parameter]
        public EventCallback<int> MyClick { get; set; }

        private Task OnClickAsync()
        {
            return MyClick.InvokeAsync(666);
        }
    }
}
