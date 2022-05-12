namespace Luotao.LearningCsharp.Test.Books.PROCN2021._10._03
{
    namespace _05
    {
        /// <summary>
        /// 10.3.5. exception filters
        /// </summary>
        public class T05
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T05(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                void F01(string code)
                {
                    throw new SystemException(code);
                }

                try
                {
                    // F01("111");
                    // F01("222");
                    F01("333");
                }
                // catch 后面使用 when 对异常作进一步的过滤, 可以使用异常对象 e 的某些属性进行过滤
                catch (SystemException e) when (e.Message == "000")
                {
                    testOutputHelper.WriteLine("A:{0}", e.Message);
                }
                catch (SystemException e) when (e.Message == "111")
                {
                    testOutputHelper.WriteLine("B:{0}", e.Message);
                }
                catch (SystemException e)
                {
                    testOutputHelper.WriteLine("C:{0}", e.Message);
                }
            }
        }
    }
}
