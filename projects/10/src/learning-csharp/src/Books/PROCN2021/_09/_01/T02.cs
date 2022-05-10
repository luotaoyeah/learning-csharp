using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._01
{
    namespace _02
    {
        /// <summary>
        /// 9.1.2. LINQ querys
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var query = from r in F1.GetChampions()
                    where r.Country == "Brazil"
                    orderby r.Wins descending
                    select r;

                foreach (var racer in query)
                {
                    testOutputHelper.WriteLine(racer.ToString("A"));
                }
            }
        }
    }
}
