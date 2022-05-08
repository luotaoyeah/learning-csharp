namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._07
{
    namespace _03
    {
        /// <summary>
        /// 6.7.3. yield statement
        /// </summary>
        public class T03
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T03(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                foreach (var i in new C01())
                {
                    testOutputHelper.WriteLine("{0}", i);
                }

                foreach (var i in new C01().F01())
                {
                    testOutputHelper.WriteLine("{0}", i);
                }
            }
        }

        class C01
        {
            public IEnumerator<int> GetEnumerator()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }

            public IEnumerable<int> F01()
            {
                yield return 3;
                yield return 2;
                yield return 1;
            }
        }
    }
}
