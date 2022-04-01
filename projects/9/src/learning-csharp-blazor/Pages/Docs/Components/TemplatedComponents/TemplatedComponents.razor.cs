using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Luotao.Blazor.Pages.Docs.Components.TemplatedComponents
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/templated-components?view=aspnetcore-5.0.
    /// </summary>
    [Route("/docs/components/templated-components")]
    public partial class TemplatedComponents
    {
        private readonly List<Pet> pets = new()
        {
            new Pet { PetId = 1, Name = "foo" },
            new Pet { PetId = 2, Name = "bar" },
            new Pet { PetId = 3, Name = "baz" },
        };
    }
}
