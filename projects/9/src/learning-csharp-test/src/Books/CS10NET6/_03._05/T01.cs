namespace Luotao.Test.Books.CS10NET6._03._05
{
    /// <summary>
    /// 3.5. handling exceptions when converting types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// catch 后面可以不指定异常类型.
        /// </summary>
        [Fact]
        public void _01()
        {
            try
            {
                var i01 = int.Parse("A");
            }
            catch
            {
                testOutputHelper.WriteLine("CATCH A EXCEPTION");
            }
        }

        /// <summary>
        /// catch 可以指定异常类型,
        /// catch 的顺序很重要, 异常类型越精确的, 越需要放在前面捕获.
        /// </summary>
        [Fact]
        public void _02()
        {
            try
            {
                var i01 = int.Parse("A");
            }
            catch (OverflowException e)
            {
                testOutputHelper.WriteLine($"{e.GetType()}: {e.Message}");
            }
            catch (FormatException e)
            {
                testOutputHelper.WriteLine($"{e.GetType()}: {e.Message}");
            }
            catch (Exception e)
            {
                testOutputHelper.WriteLine($"{e.GetType()}: {e.Message}");
            }
        }
    }
}
