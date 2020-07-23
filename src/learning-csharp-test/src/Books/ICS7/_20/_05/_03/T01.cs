namespace Luotao.Test.Books.ICS7._20._05._03
{
    /// <summary>
    /// 20.5.3 what is a join ?
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// LINQ 中的 join 跟 SQL 中的 join 类似.
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

            // 两个集合的先后顺序, 不影响 join 的结果

            var query01 =
                from sc in studentsInCourses
                join s in students on sc.StID equals s.StID
                select new { sc.StID, s.LastName, sc.CourseName };

            testOutputHelper.WriteLine($"{"ID",-4}{"CourseName",-15}{"LastName",-15}");
            foreach (var x in query01)
            {
                testOutputHelper.WriteLine($"{x.StID,-4}{x.CourseName,-15}{x.LastName,-15}");
            }

            testOutputHelper.WriteLine("---------------------------------");

            var query02 =
                from s in students
                join sc in studentsInCourses on s.StID equals sc.StID
                select new { s.StID, s.LastName, sc.CourseName };

            testOutputHelper.WriteLine($"{"ID",-4}{"LastName",-15}{"CourseName",-15}");
            foreach (var x in query02)
            {
                testOutputHelper.WriteLine($"{x.StID,-4}{x.LastName,-15}{x.CourseName,-15}");
            }
        }
    }
}
