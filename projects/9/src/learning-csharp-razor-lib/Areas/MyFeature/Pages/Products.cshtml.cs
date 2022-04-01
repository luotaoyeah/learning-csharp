using System.Collections.Generic;
using System.Linq;
using Luotao.Northwind;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Luotao.RazorLib.Areas.MyFeature.Pages
{
    public class ProductsModel : PageModel
    {
        private NorthwindDbContext db;

        public ProductsModel(NorthwindDbContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Product>? Products { get; set; }

        public void OnGet()
        {
            Products = db.Products?.Include((i) => i.Category).ToArray();
        }
    }
}
