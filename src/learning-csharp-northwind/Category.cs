using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luotao.Northwind
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
