namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._06
{
    /// <summary>
    /// 2.6.3. FormattableString
    /// </summary>
    public class _03
    {
        [Fact]
        public void _01()
        {
            int x = 1;
            int y = 2;
            FormattableString str01 = $"{x} + {y} = {x + y}";

            Assert.Equal(str01.Format, "{0} + {1} = {2}");
            Assert.Equal(str01.ArgumentCount, 3);
            Assert.Equal(str01.GetArgument(0), 1);
            Assert.Equal(str01.GetArgument(1), 2);
            Assert.Equal(str01.GetArgument(2), 3);
        }
    }
}
