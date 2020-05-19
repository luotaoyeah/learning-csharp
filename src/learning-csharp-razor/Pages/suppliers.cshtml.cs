using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LT.Razor.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string>? Suppliers { get; private set; }

        public void OnGet()
        {
            ViewData["Title"] = "suppliers";

            Suppliers = new[] { "A", "B", "C" };
        }
    }
}
