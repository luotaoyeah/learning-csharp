using System;

namespace Luotao.Blazor.Services
{
    /// <summary>
    /// 测试服务.
    /// </summary>
    public sealed class DisposableService : IDisposable
    {
        /// <summary>
        /// F01.
        /// </summary>
        /// <returns>一个随机整数.</returns>
        public int F01()
        {
            return new Random().Next(1, 9);
        }

        public void Dispose()
        {
            Console.WriteLine($"{nameof(DisposableService)}.{nameof(Dispose)}()");
        }
    }
}
