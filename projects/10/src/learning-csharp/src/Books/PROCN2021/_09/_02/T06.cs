using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _06
    {
        /// <summary>
        /// 9.2.6. grouping
        /// </summary>
        public class T06
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T06(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var query = from r in F1.GetChampions()
                    group r by r.Country
                    into g
                    orderby g.Count() descending, g.Key
                    where g.Count() >= 2
                    select new
                    {
                        Country = g.Key,
                        Count = g.Count()
                    };

                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine($"{x1.Country,-10}{x1.Count}");
                }
            }

            [Fact]
            public void _02()
            {
                var query = F1.GetChampions()
                    .GroupBy(r => r.Country)
                    .OrderByDescending(g => g.Count())
                    .ThenBy(g => g.Key)
                    .Where(g => g.Count() >= 2)
                    .Select(g => new { Country = g.Key, Count = g.Count() });

                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine($"{x1.Country,-10}{x1.Count}");
                }
            }
        }
    }
}
