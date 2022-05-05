namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._03
{
    namespace _09
    {
        /// <summary>
        /// 3.3.9. anonymous types
        /// </summary>
        public class T09
        {
            [Fact]
            public void _01()
            {
                var person = new { Name = "luotao", Age = 18 };
                Assert.Equal(18, person.Age);
            }
        }
    }
}
