using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._03._11
{
    /// <summary>
    ///     5.3.11 setting fields with default literals
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
            var person = new Person01();
            Assert.Equal(0, person.Population);
            Assert.Null(person.Name);
            Assert.Equal("0001-01-01 00:00:00", person.When.ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.Null(person.People);
        }

        [Fact]
        public void _02()
        {
            var person = new Person02();
            Assert.Equal(0, person.Population);
            Assert.Null(person.Name);
            Assert.Equal("0001-01-01 00:00:00", person.When.ToString("yyyy-MM-dd HH:mm:ss"));
            Assert.Null(person.People);
        }
    }

    public class Person01
    {
        public string? Name;
        public List<Person01>? People;
        public int Population;
        public DateTime When;
    }

    public class Person02
    {
        public string? Name;
        public List<Person02>? People;
        public int Population;
        public DateTime When;

        /// <summary>
        ///     从 C# 7.1 开始, default 操作符可以推测类型, 因此可以省略它后面的类型.
        /// </summary>
        public Person02()
        {
            Population = default;
            Name = default;
            When = default;
            People = default;
        }
    }
}
