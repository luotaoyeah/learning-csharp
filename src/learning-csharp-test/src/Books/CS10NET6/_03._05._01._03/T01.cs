namespace Luotao.Test.Books.CS10NET6._03._05._01._03
{
    /// <summary>
    /// 3.5.1.3. catching with filters
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// catch 后面可以使用 `when ()` 来过滤.
        /// </summary>
        [Fact]
        public void _01()
        {
            int flag = new Random().Next(1, 4);

            try
            {
                var i01 = int.Parse("A");
            }
            catch (FormatException e) when (flag == 1)
            {
                testOutputHelper.WriteLine("1");
            }
            catch when (flag == 2)
            {
                testOutputHelper.WriteLine("2");
            }
            catch
            {
                testOutputHelper.WriteLine("3");
            }
        }
    }
}
