using System.Linq.Expressions;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._04
{
    namespace _04
    {
        /// <summary>
        /// 9.4. expression trees
        /// </summary>
        public class T04
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T04(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                Expression<Func<int, bool>> expression = i => i > 0;
                testOutputHelper.WriteLine(expression.ToString());
            }
        }
    }
}
