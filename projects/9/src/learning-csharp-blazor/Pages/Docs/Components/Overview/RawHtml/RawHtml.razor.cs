using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.RawHtml
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#raw-html-1.
    /// </summary>
    [Route("/docs/components/raw-html")]
    public partial class RawHtml
    {
        private readonly string html01 = "<div style=\"color:red;\">HTML</div>";
        private readonly MarkupString html02 = new("<div style=\"color:red;\">HTML</div>");
    }
}
