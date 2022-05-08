namespace Luotao.LearningCsharp.Test.Books.PROCN2021._05._01
{
    namespace _07
    {
        /// <summary>
        /// 5.1.7. the nameof expression
        /// </summary>
        public class T07
        {
            [Fact]
            public void _01()
            {
                Assert.Equal("Person", nameof(Person));

                var person = new Person();
                Assert.Equal("F01", nameof(person.F01));
                Assert.Equal("Age", nameof(person.Age));
            }
        }

        class Person
        {
            public int Age { get; set; }

            public void F01()
            {
            }
        }
    }
}
