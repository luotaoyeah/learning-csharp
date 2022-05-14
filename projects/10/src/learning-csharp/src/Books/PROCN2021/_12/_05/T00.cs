using System.Dynamic;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._12._05
{
    namespace _00
    {
        /// <summary>
        /// 12.5. ExpandoObject
        /// </summary>
        public class T00
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T00(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                dynamic? obj = new ExpandoObject();

                obj.X = 1;
                obj.Y = 2;
                obj.Add = new Func<int, int, int>(
                    (x, y) => x + y
                );

                Assert.Equal(3, obj.Add(obj.X, obj.Y));
            }
        }
    }
}
