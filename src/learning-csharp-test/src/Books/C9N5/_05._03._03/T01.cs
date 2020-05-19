using System;
using Luotao.Lib.Books.C9N5._05;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.C9N5._05._03._03
{
    /// <summary>
    ///     5.3.3 setting and outputting field values
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
            var person = new Person();
            person.Name = "luotao";
            person.DateOfBirth = new DateTime(1990, 1, 1);

            testOutputHelper.WriteLine("{0} was born on {1:yyyy-MM-dd}", person.Name, person.DateOfBirth);
        }

        [Fact]
        public void _02()
        {
            var person = new Person
            {
                Name = "luotao",
                DateOfBirth = new DateTime(1990, 1, 1)
            };

            testOutputHelper.WriteLine($"{person.Name} was born on {person.DateOfBirth:yyyy-MM-dd}");
        }
    }
}
