using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _05
    {
        /// <summary>
        /// 9.2.5. sorting
        /// </summary>
        public class T05
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T05(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var query = (from r in F1.GetChampions()
                    orderby r.Country, r.LastName descending, r.FirstName ascending
                    select r).Take(10);

                foreach (var racer in query)
                {
                    testOutputHelper.WriteLine(racer.ToString("A"));
                }
            }

            [Fact]
            public void _02()
            {
                var query = F1.GetChampions()
                    .OrderBy(r => r.Country)
                    .ThenByDescending(r => r.LastName)
                    .ThenBy(r => r.FirstName)
                    .Take(10);

                foreach (var racer in query)
                {
                    testOutputHelper.WriteLine(racer.ToString("A"));
                }
            }
        }
    }
}
