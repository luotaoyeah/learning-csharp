using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Luotao.Blazor.Pages.Docs.Components.Virtualization
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/virtualization?view=aspnetcore-5.0.
    /// </summary>
    [Route("/docs/components/virtualization")]
    public partial class Virtualization
    {
        private readonly List<Flight> allFlights = new();

        /// <summary>
        /// Virtualization.
        /// </summary>
        public Virtualization()
        {
            for (var i = 0; i < 1000; i++)
            {
                allFlights.Add(new Flight { FlightId = i, Summary = i.ToString() });
            }
        }
    }
}
