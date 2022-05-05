namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._03
{
    namespace _08
    {
        /// <summary>
        /// 3.3.8. extension methods
        /// </summary>
        public class T08
        {
            [Fact]
            public void _01()
            {
                string str01 = "foo";

                Assert.Equal(str01.F01(), 6);

                // 扩展方法实际上就是语法糖, 可以用下面的方式来调用
                Assert.Equal(StringExtensions.F01(str01), 6);
            }
        }

        public static class StringExtensions
        {
            public static int F01(this string str)
            {
                return 6;
            }
        }
    }
}
