using System.Runtime.CompilerServices;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._10._05
{
    namespace _00
    {
        /// <summary>
        /// 10.5. caller information
        /// </summary>
        public class T00
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T00(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01(
            )
            {
                // 获取该方法被调用时的相关信息,
                //   CallerFilePath:   源文件的完整路径
                //   CallerLineNumber: 行号
                //   CallerMemberName: 调用者的方法或属性名
                void F01(
                    [CallerLineNumber] int callerLineNumber = -1,
                    [CallerFilePath] string callerFilePath = default!,
                    [CallerMemberName] string callerMemberName = default!
                )
                {
                    testOutputHelper.WriteLine("CallerFilePath: {0}", callerFilePath);
                    testOutputHelper.WriteLine("CallerLineNumber: {0}", callerLineNumber);
                    testOutputHelper.WriteLine("CallerMemberName: {0}", callerMemberName);
                }

                F01();
            }
        }
    }
}
