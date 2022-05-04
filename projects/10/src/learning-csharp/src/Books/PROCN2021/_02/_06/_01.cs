using System.Text;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._06
{
    /// <summary>
    /// 2.6.1. using the StringBuilder
    /// </summary>
    public class _01
    {
        [Fact]
        public void _02()
        {
            StringBuilder sb = new("foo");
            sb.Append("bar");
            Assert.Equal(sb.ToString(), "foobar");

            sb.Insert(3, '-');
            Assert.Equal(sb.ToString(), "foo-bar");

            sb.Remove(3, 1);
            Assert.Equal(sb.ToString(), "foobar");

            sb.Replace('o', 'O');
            Assert.Equal(sb.ToString(), "fOObar");
        }
    }
}
