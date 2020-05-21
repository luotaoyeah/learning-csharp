using System.Collections.Generic;
using System.Linq;
using Luotao.Northwind;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Luotao.Razor.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly NorthwindDbContext db;

        public ProductsModel(NorthwindDbContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<string>? Products { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "products";

            Products = db.Products?.Select(i => i.ProductName ?? string.Empty);
        }
    }
}
