using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Luotao.Razor.Pages
{
    public class IndexModel : PageModel
    {
        public string? Time { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "learning-csharp-razor";

            Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
