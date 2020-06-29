using Luotao.Lib.Books.ICS7._21._03._01._01;
using System.Threading.Tasks;

namespace Luotao.Test.Books.ICS7._21._03._01._01
{
    /// <summary>
    ///     21.3.1.1 the await expression
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async void _01()
        {
            Task<int> task = new MyClass().DoWorkAsync();
            testOutputHelper.WriteLine(task.Result.ToString());
        }
    }
}
