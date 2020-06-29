namespace Luotao.Test.Books.ICS7._20._02._01
{
    /// <summary>
    ///     20.2.1 anonymous types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 object creation expression 创建一个 anonymous type 的对象，此时没有指定 class 的名称，
        /// </summary>
        [Fact]
        public void _01()
        {
            var student = new { Name = "Mary Jones", Age = 19, Major = "History" };
            Assert.Equal("Mary Jones", student.Name);
            Assert.Equal(19, student.Age);
            Assert.Equal("History", student.Major);
        }

        /// <summary>
        ///     anonymous type 对象的属性是只读的，
        /// </summary>
        [Fact]
        public void _02()
        {
            var student = new { Name = "Mary Jones", Age = 19, Major = "History" };
            // [CS0200]
            // student.Age = 20;
        }

        [Fact]
        public void _03()
        {
            var Other = new { Name = "Mary Jones" };
            string Major = "History";

            var student01 = new { Other.Name, Age = 19, Major };
            //----------------------------------------------------------------------------------------------------
            // 如下的形式称之为 projection initializer
            //----------------------------------------------------------------------------------------------------
            var student02 = new { Other.Name, Age = 19, Major };

            Assert.Equal(student01.Name, student02.Name);
            Assert.Equal(student01.Age, student02.Age);
            Assert.Equal(student01.Major, student02.Major);
        }
    }
}
