using Luotao.Northwind;
using Microsoft.EntityFrameworkCore;

namespace Luotao.Test.Books.CS10NET6._11._04._02
{
    /// <summary>
    ///     11.4.2 filtering and sorting products
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
                var products = db.Products.Where(i => i.Cost > 20).OrderBy(i => i.Cost);

                testOutputHelper.WriteLine(products.ToQueryString());
                testOutputHelper.WriteLine("----------");
                foreach (var product in products) testOutputHelper.WriteLine($"{product.ProductName,-40}{product.Cost}");
            }
        }
    }
}
