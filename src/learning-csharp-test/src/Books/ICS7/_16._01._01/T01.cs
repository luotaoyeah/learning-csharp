using System;
using LuotaoYeah.Lib.Books.ICS7._16._01._01;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._16._01._01
{
    /// <summary>
    ///     16.1.1 example using the IComparable interface
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
            MyClass[] myClasses =
            {
                new() { TheValue = 3 },
                new() { TheValue = 4 },
                new() { TheValue = 2 },
                new() { TheValue = 1 }
            };

            foreach (var myClass in myClasses) testOutputHelper.WriteLine(myClass.ToString());

            testOutputHelper.WriteLine("----------");

            Array.Sort(myClasses);

            foreach (var myClass in myClasses) testOutputHelper.WriteLine(myClass.ToString());
        }
    }
}
