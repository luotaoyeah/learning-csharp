using Microsoft.AspNetCore.Components;
using System;

namespace Luotao.Blazor.Pages.Docs.Components.DataBinding
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0#format-strings-1.
    /// </summary>
    [Route("/docs/components/data-binding/format-strings")]
    public partial class FormatStrings
    {
        private DateTime? inputValue = DateTime.Now;
    }
}
