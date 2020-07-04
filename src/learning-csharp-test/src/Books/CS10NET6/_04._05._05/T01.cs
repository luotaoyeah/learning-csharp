namespace Luotao.Test.Books.CS10NET6._04._05._05
{
    /// <summary>
    /// 4.5.5. rethrowing exceptions
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
            Assert.Throws<FormatException>(
                () =>
                {
                    try
                    {
                        var i01 = int.Parse("A");
                    }
                    catch (Exception e)
                    {
                        testOutputHelper.WriteLine(e.StackTrace);

                        // 直接使用 `throw;` 重新抛出捕获的异常, 将保留原始的 call stack
                        throw;
                    }
                }
            );
        }

        [Fact]
        public void _02()
        {
            Assert.Throws<FormatException>(
                () =>
                {
                    try
                    {
                        var i01 = int.Parse("A");
                    }
                    catch (Exception e)
                    {
                        testOutputHelper.WriteLine(e.StackTrace);

                        // 使用 `throw e;` 重新抛出捕获的异常, 将改变 call stack
                        throw e;
                    }
                }
            );
        }

        [Fact]
        public void _03()
        {
            Assert.Throws<ArgumentException>(
                () =>
                {
                    try
                    {
                        var i01 = int.Parse("A");
                    }
                    catch (Exception e)
                    {
                        testOutputHelper.WriteLine(e.StackTrace);

                        // 抛出一个新的异常类型, 并将捕获的异常作为 innerException 传入
                        throw new ArgumentException(string.Empty, e);
                    }
                }
            );
        }
    }
}
