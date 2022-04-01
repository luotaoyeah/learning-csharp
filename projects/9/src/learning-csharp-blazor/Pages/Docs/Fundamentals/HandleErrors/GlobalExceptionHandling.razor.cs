using Luotao.Blazor.Shared;
using Microsoft.AspNetCore.Components;
using System;

namespace Luotao.Blazor.Pages.Docs.Fundamentals.HandleErrors
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/handle-errors?view=aspnetcore-5.0&pivots=webassembly#global-exception-handling.
    /// </summary>
    [Route("/docs/fundamentals/handle-errors/global-exception-handling")]
    public partial class GlobalExceptionHandling
    {
        [CascadingParameter]
        public Error? Error { get; set; }

        private void OnClick()
        {
#pragma warning disable CA2201
            Error?.ProcessError(new Exception("0000"));
#pragma warning restore CA2201
        }
    }
}
