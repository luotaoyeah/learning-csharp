using System;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._05._03._10
{
    /// <summary>
    /// 5.3.10 initializing fields with constructors
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
            Assert.Equal("Unknown", person.Name);
            testOutputHelper.WriteLine(person.Instantiated.ToString("HH:mm:ss"));
        }

        [Fact]
        public void _02()
        {
            var person = new Person(name: "luotao");
            Assert.Equal("luotao", person.Name);
            testOutputHelper.WriteLine(person.Instantiated.ToString("HH:mm:ss"));
        }
    }

    public class Person
    {
        public readonly DateTime Instantiated;
        public string? Name;

        public Person(string? name)
        {
            Name = name;
            Instantiated = DateTime.Now;
        }

        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
    }
}
