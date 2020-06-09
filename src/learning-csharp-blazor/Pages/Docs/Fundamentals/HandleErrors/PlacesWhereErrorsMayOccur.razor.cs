using Luotao.Blazor.Shared;
using Microsoft.AspNetCore.Components;
using System;

#pragma warning disable CA2201
namespace Luotao.Blazor.Pages.Docs.Fundamentals.HandleErrors
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/handle-errors?view=aspnetcore-5.0&pivots=webassembly#places-where-errors-may-occur-2.
    /// </summary>
    [Route("/docs/fundamentals/handle-errors/places-where-errors-may-occur")]
    public partial class PlacesWhereErrorsMayOccur
    {
        public PlacesWhereErrorsMayOccur()
        {
            Console.WriteLine("ERROR in component constructor");
        }

        [CascadingParameter]
        public Error? Error { get; set; }

        protected Exception? Exception { get; set; }

        protected override void OnInitialized()
        {
            Error?.ProcessError(new Exception("ERROR in lifecycle method"));
        }

        private void OnClick()
        {
            Error?.ProcessError(new Exception("ERROR in event handler"));
        }
    }
}
#pragma warning restore CA2201
