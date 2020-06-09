using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Overview.RawHtml
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-5.0#raw-html.
    /// </summary>
    [Route("/docs/components/raw-html")]
    public sealed partial class RawHtml
    {
        private readonly string html = "<div style=\"color:red;\">HTML</div>";
    }
}
