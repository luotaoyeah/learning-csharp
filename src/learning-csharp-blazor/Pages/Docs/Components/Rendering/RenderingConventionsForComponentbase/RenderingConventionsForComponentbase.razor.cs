using Microsoft.AspNetCore.Components;

namespace Luotao.Blazor.Pages.Docs.Components.Rendering.RenderingConventionsForComponentbase
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/components/rendering?view=aspnetcore-5.0#rendering-conventions-for-componentbase.
    /// </summary>
    [Route("/docs/components/rendering/rendering-conventions-for-componentbase")]
    public partial class RenderingConventionsForComponentbase
    {
        private readonly Person person = new() { Age = 6 };
        private int x = 6;

        private void UpdatePersonAge()
        {
            person.Age = 9;
        }

        private void UpdateX()
        {
            x = 9;
        }

        /// <summary>
        /// 给 X 赋值, 但是赋的值跟原来的值相同.
        /// </summary>
        private void UpdateX02()
        {
            x = 6;
        }
    }
}
