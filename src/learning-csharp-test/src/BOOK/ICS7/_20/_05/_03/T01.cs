using System.Linq;
using LT.BOOK.ICS7._20._05._03;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._20._05._03
{
    /// <summary>
    /// 20.5.3 what is a join?
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// LINQ 中的 join 跟 SQL 中的 join 类似，
        /// </summary>
        [Fact]
        public void _01()
        {
            Student[] students = new Student[]
            {
                new Student { StID = 1, LastName = "Carson" },
                new Student { StID = 2, LastName = "Klassen" },
                new Student { StID = 3, LastName = "Fleming" },
                new Student { StID = 4, LastName = "AAA" },
            };

            CourseStudent[] studentsInCourses = new CourseStudent[]
            {
                new CourseStudent { CourseName = "Art", StID = 1 },
                new CourseStudent { CourseName = "Art", StID = 2 },
                new CourseStudent { CourseName = "History", StID = 1 },
                new CourseStudent { CourseName = "History", StID = 3 },
                new CourseStudent { CourseName = "Physics", StID = 3 },
                new CourseStudent { CourseName = "BBB", StID = 5 },
            };

            var query =
                from s in students
                join cs in studentsInCourses on s.StID equals cs.StID
                select new { s.LastName, s.StID, cs.CourseName };

            foreach (var x in query)
            {
                testOutputHelper.WriteLine($"{x.StID}\t{x.LastName}\t{x.CourseName}");
            }
        }
    }
}
