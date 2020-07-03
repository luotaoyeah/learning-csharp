namespace Luotao.Test.Books.CS10NET6._04._01._06
{
    /// <summary>
    /// 4.1.6. using lambdas in function implementations
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
            for (var i = 1; i < 10; i++)
            {
                testOutputHelper.WriteLine(Fibonacci01(i).ToString());
            }

            testOutputHelper.WriteLine("----------");

            for (var i = 1; i < 10; i++)
            {
                testOutputHelper.WriteLine(Fibonacci02(i).ToString());
            }
        }

        private static int Fibonacci01(int value)
        {
            if (value == 1)
            {
                return 0;
            }

            if (value == 2)
            {
                return 1;
            }

            return Fibonacci01(value - 1) + Fibonacci01(value - 2);
        }

        private static int Fibonacci02(int value)
        {
            return value switch
            {
                // 这是一个 lambda
                1 => 0,
                2 => 1,
                _ => Fibonacci02(value - 1) + Fibonacci02(value - 2)
            };
        }
    }
}
