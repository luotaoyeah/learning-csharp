using Luotao.Northwind;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._11._04
{
    /// <summary>
    ///     11.4 querying EF Core models
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            using (var db = new NorthwindDbContext())
            {
                var queryable = db.Categories.Include(category => category.Products);

                foreach (var category in queryable) testOutputHelper.WriteLine("{0}{1}", category.CategoryName, category.Products.Count);
            }
        }
    }
}
