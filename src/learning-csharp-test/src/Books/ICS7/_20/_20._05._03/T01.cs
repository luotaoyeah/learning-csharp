using Luotao.Lib.Books.ICS7._20._05._03;

namespace Luotao.Test.Books.ICS7._20._05._03
{
    /// <summary>
    ///     20.5.3 what is a join?
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     LINQ 中的 join 跟 SQL 中的 join 类似,
        /// </summary>
        [Fact]
        public void _01()
        {
            Student[] students =
            {
                new() { StID = 1, LastName = "Carson" },
                new() { StID = 2, LastName = "Klassen" },
                new() { StID = 3, LastName = "Fleming" },
                new() { StID = 4, LastName = "AAA" }
            };

            CourseStudent[] studentsInCourses =
            {
                new() { CourseName = "Art", StID = 1 },
                new() { CourseName = "Art", StID = 2 },
                new() { CourseName = "History", StID = 1 },
                new() { CourseName = "History", StID = 3 },
                new() { CourseName = "Physics", StID = 3 },
                new() { CourseName = "BBB", StID = 5 }
            };

            var query =
                from s in students
                join cs in studentsInCourses on s.StID equals cs.StID
                select new { s.LastName, s.StID, cs.CourseName };

            foreach (var x in query) testOutputHelper.WriteLine($"{x.StID}\t{x.LastName}\t{x.CourseName}");
        }
    }
}
