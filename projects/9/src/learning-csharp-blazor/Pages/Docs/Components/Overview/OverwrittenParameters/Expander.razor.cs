using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.OverwrittenParameters
{
    /// <summary>
    /// Expander.
    /// </summary>
    public partial class Expander
    {
        private bool expanded;

        /// <summary>
        /// Parameter 参数应该被当成是只读的, 因此组件不应该直接去修改参数的值.
        /// </summary>
        [Parameter]
        public bool Expanded { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        /// <inheritdoc />
        protected override void OnInitialized()
        {
            expanded = Expanded;
        }

        protected void ToggleExpanded()
        {
            expanded = !expanded;
        }
    }
}
