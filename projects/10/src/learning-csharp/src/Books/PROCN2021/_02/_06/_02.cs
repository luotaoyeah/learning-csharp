namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._06
{
    /// <summary>
    /// 2.6.2. string interpolation
    /// </summary>
    public class _02
    {
        [Fact]
        public void _01()
        {
            int x = 1;
            int y = 2;
            string str01 = $"{x} + {y} = {x + y}";
            string str02 = string.Format("{0} + {1} = {2}", x, y, x + y);
            Assert.Equal(str01, str02);
        }
    }
}
