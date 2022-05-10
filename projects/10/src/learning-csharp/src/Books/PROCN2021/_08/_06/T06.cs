namespace Luotao.LearningCsharp.Test.Books.PROCN2021._08._06
{
    namespace _06
    {
        /// <summary>
        /// 8.6. sorted list
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
                // key 不能重复
                SortedList<string, string> list01 = new();
                list01.Add("A", "AAA");
                list01.Add("C", "CCC");
                list01.Add("B", "BBB");

                foreach (var (key, value) in list01)
                {
                    testOutputHelper.WriteLine("{0}:{1}", key, value);
                }
            }
        }
    }
}
