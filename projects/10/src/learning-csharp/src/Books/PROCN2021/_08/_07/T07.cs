namespace Luotao.LearningCsharp.Test.Books.PROCN2021._08._07
{
    namespace _07
    {
        /// <summary>
        /// 8.7. dictionaries
        /// </summary>
        public class T07
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T07(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                // dictionaries initializer
                Dictionary<string, string> dict01 = new()
                {
                    ["A"] = "1",
                    ["B"] = "2",
                    ["C"] = "3",
                };

                foreach (string key in dict01.Keys)
                {
                    testOutputHelper.WriteLine(key);
                }

                foreach (string value in dict01.Values)
                {
                    testOutputHelper.WriteLine(value);
                }
            }

            [Fact]
            public void _02()
            {
                Dictionary<string, string> dict01 = new()
                {
                    { "A", "1" },
                    { "B", "2" },
                    { "C", "3" },
                };

                foreach (string key in dict01.Keys)
                {
                    testOutputHelper.WriteLine(key);
                }

                foreach (string value in dict01.Values)
                {
                    testOutputHelper.WriteLine(value);
                }
            }
        }
    }
}
