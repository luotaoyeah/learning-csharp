namespace Luotao.Test.Books.ICS7._20._02._01
{
    /// <summary>
    /// 20.2.1 anonymous types
    /// </summary>
    public class T01
    {
        /// <summary>
        /// 匿名类型的属性是只读的.
        /// </summary>
        [Fact]
        public void _01()
        {
            var student = new { Name = "Mary Jones", Age = 19, Major = "History" };
            Assert.Equal("Mary Jones", student.Name);
            Assert.Equal(19, student.Age);
            Assert.Equal("History", student.Major);

            // student.Age = 20;
        }

        [Fact]
        public void _02()
        {
            var other = new { Name = "Mary Jones" };
            string Major = "History";

            // 匿名类型的属性有下面三种指定方式:
            var student01 = new { Age = 19, other.Name, Major };
            var student02 = new { Age = 19, Name = other.Name, Major = Major };

            Assert.Equal(student01.Name, student02.Name);
            Assert.Equal(student01.Age, student02.Age);
            Assert.Equal(student01.Major, student02.Major);
        }
    }
}
