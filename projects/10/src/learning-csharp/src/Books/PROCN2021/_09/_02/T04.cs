namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _04
    {
        /// <summary>
        /// 9.2.4. compound from
        /// </summary>
        public class T04
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T04(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var items = new[]
                {
                    new Person() { Name = "小红", Cars = new List<string> { "A", "B" } },
                    new Person() { Name = "小明", Cars = new List<string> { "C", "D" } },
                };

                // 两个 from 挨着使用, 称为 compound from, 相当于嵌套的循环,
                // 将集合的每个元素映射为一个新的集合, 然后打平,
                var query01 =
                    from person in items
                    from car in person.Cars
                    select new { person, car };

                foreach (var x1 in query01)
                {
                    testOutputHelper.WriteLine("{0}, {1}", x1.person.Name, x1.car);
                }
            }

            [Fact]
            public void _02()
            {
                var items = new[]
                {
                    new Person() { Name = "小红", Cars = new List<string> { "A", "B" } },
                    new Person() { Name = "小明", Cars = new List<string> { "C", "D" } },
                };

                var query01 = items.SelectMany(person => person.Cars, (person, car) => new { person, car });

                foreach (var x1 in query01)
                {
                    testOutputHelper.WriteLine("{0}, {1}", x1.person.Name, x1.car);
                }
            }
        }

        class Person
        {
            public string Name { get; set; }

            public List<string> Cars { get; set; }
        }
    }
}
