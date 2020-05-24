using System;

#pragma warning disable CA5394

namespace Luotao.Blazor.Services
{
    /// <summary>
    /// 测试服务.
    /// </summary>
    public class TestService : ITestService
    {
        /// <summary>
        /// F01.
        /// </summary>
        /// <returns>随机数字.</returns>
        public int F01()
        {
            return new Random().Next(1, 9);
        }
    }
}

#pragma warning restore CA5394
