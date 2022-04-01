namespace Luotao.Test.Books.CS10NET6._03._02._05
{
    /// <summary>
    /// 3.2.5 simplifying switch statements with switch expressions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 适用 switch expression 的简单场景: 所有的 case 都对同一个变量赋值.
        /// </summary>
        [Fact]
        public void _01()
        {
            var i01 = new Random().Next(1, 9);
            string s01 = i01 switch
            {
                1 => "壹",
                2 => "贰",
                3 => "叁",
                4 => "肆",
                5 => "伍",
                6 => "陆",
                7 => "柒",
                8 => "捌",
                9 => "玖",
                // _ 表示 default
                _ => "零"
            };

            testOutputHelper.WriteLine(s01);
        }
    }
}
