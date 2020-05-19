using System.Collections.Generic;
using System.Linq;
using Luotao.Northwind;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Luotao.Razor.Pages
{
    public class SuppliersModel : PageModel
    {
        private readonly NorthwindDbContext db;

        public SuppliersModel(NorthwindDbContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<string>? Suppliers { get; private set; }

        public void OnGet()
        {
            ViewData["Title"] = "suppliers";

            Suppliers = db.Products?.Select(i => i.ProductName ?? string.Empty);
        }
    }
}
