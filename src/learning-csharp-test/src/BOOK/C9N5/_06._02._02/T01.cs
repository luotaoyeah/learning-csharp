using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._06._02._02
{
    /// <summary>
    ///     6.2.2 implementing functionality using operators
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
            var father = new Person { Name = "张三" };
            var mother = new Person { Name = "李四" };

            var child01 = Person.Procreate(father, mother);
            Assert.Equal("baby of 张三 and 李四", child01.Name);

            var child02 = father * mother;
            Assert.Equal("baby of 张三 and 李四", child02.Name);
        }
    }

    public class Person
    {
        public List<Person> Children = new();
        public string? Name;

        public static Person Procreate(Person p1, Person p2)
        {
            var person = new Person
            {
                Name = $"baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(person);
            p2.Children.Add(person);

            return person;
        }

        /// <summary>
        ///     自定义的 operator 本质上是一个静态方法.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Person operator *(Person p1, Person p2)
        {
            return Procreate(p1, p2);
        }
    }
}
