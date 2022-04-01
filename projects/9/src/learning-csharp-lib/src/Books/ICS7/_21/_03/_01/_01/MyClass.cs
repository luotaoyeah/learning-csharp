using System.Threading.Tasks;

namespace Luotao.Lib.Books.ICS7._21._03._01._01
{
    public class MyClass
    {
        public int Get10()
        {
            return 10;
        }

        /// <summary>
        ///     await 后面是一个 awaitable object，
        ///     awaitable object 指的是具有 GetAwaiter() 方法的对象，
        ///     <see cref="Task{TResult}" /> 是最常用的 awaitable object，
        ///     调用一个 async method 可以得到一个 Task 对象（如果它的返回值是 Task 的话），
        ///     比如 <see cref="System.Net.WebClient.DownloadStringTaskAsync(string)" /> 方法，
        ///     我们也可以使用 <see cref="Task.Run(System.Action)" /> 方法返回一个 Task 对象
        /// </summary>
        /// <returns></returns>
        public async Task<int> DoWorkAsync()
        {
            // 直接传入一个 function，这个 function 会被包装成一个 delegate 对象，
            var a = await Task.Run(Get10);
            // 显式地创建一个 delegate 对象并传入，
            var b = await Task.Run(Get10);
            // 传入一个 lambda expression
            var c = await Task.Run(() => Get10());
            return a + b + c;
        }
    }
}
