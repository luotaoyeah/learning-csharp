namespace Luotao.Test.Books.ICS7._20._05._08
{
    /// <summary>
    /// 20.5.8 the group clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// group...by... 用来分组, 返回 <see cref="IGrouping{TKey,TElement}" /> 类型的集合.
        /// </summary>
        [Fact]
        public void _01()
        {
            var students = new[]
            {
                new { LName = "Jones", FName = "Mary", Age = 19, Major = "History" },
                new { LName = "Smith", FName = "Bob", Age = 20, Major = "CompSci" },
                new { LName = "Fleming", FName = "Carol", Age = 21, Major = "History" }
            };

            var query =
                from student in students
                group student by student.Major;

            foreach (var grouping in query)
            {
                testOutputHelper.WriteLine($"{grouping.Key}:");

                foreach (var student in grouping)
                {
                    testOutputHelper.WriteLine($"\t\t\t{student.FName,-15}{student.LName,-15}{student.Age,-15}");
                }
            }
        }
    }
}
