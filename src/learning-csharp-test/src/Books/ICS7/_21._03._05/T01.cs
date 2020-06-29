using Luotao.Lib.Books.ICS7._21._03._05;
using System.Threading.Tasks;

namespace Luotao.Test.Books.ICS7._21._03._05
{
    /// <summary>
    ///     21.3.5 the Task.Delay method
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            Simple simple = new(testOutputHelper.WriteLine);
            Task task = simple.ShowDelayAsync();
            task.Wait();
        }
    }
}
