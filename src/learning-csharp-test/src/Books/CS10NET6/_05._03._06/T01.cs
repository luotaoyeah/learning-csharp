using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._03._06
{
    /// <summary>
    ///     5.3.6 storing multiple values using collections
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
            person.Children.Add(new Person { Name = "luotao" });
            person.Children.Add(new Person { Name = "owen" });

            Assert.Equal(2, person.Children.Count);

            foreach (var child in person.Children) testOutputHelper.WriteLine(child.Name);
        }
    }

    public class Person
    {
        public List<Person> Children = new();
        public string? Name;
    }
}
