using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.C9N5._03._04._07
{
    /// <summary>
    ///     3.4.7 handling exceptions when converting types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     catch 后面可以不指定异常类型.
        /// </summary>
        [Fact]
        public void _01()
        {
            try
            {
                var i01 = int.Parse("A");
            }
            catch
            {
                testOutputHelper.WriteLine("CATCH A EXCEPTION");
            }
        }

        /// <summary>
        ///     catch 后面可以指定异常类型.
        /// </summary>
        [Fact]
        public void _02()
        {
            try
            {
                var i01 = int.Parse("A");
            }
            catch (FormatException e)
            {
                testOutputHelper.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                testOutputHelper.WriteLine(e.Message);
            }
        }
    }
}
