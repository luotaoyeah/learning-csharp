using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _10
    {
        /// <summary>
        /// 9.2.10. left outer join
        /// </summary>
        public class T10
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T10(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var query = from t in Teacher.Teachers()
                    join s in Student.Students()
                        on t.Class equals s.Class
                        into students
                    from student in students.DefaultIfEmpty()
                    select new
                    {
                        Teacher = t.Name,
                        Student = student?.Name,
                        Class = t.Class,
                    };

                testOutputHelper.WriteLine("{0,-10}\t\t{1,-10}\t{2,-10}", "老师", "学生", "班级");
                testOutputHelper.WriteLine("----------------------------------------");
                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine("{0,-10}\t{1,-10}\t{2,-10}", x1.Teacher, x1.Student, x1.Class);
                }
            }

            [Fact]
            public void _02()
            {
                var query = Teacher.Teachers()
                    .GroupJoin(Student.Students(), t => t.Class, s => s.Class, (t, students) => new { t, students })
                    .SelectMany(
                        @t1 => @t1.students.DefaultIfEmpty(),
                        (@t1, student) => new { Teacher = @t1.t.Name, Student = student?.Name, Class = @t1.t.Class, }
                    );

                testOutputHelper.WriteLine("{0,-10}\t\t{1,-10}\t{2,-10}", "老师", "学生", "班级");
                testOutputHelper.WriteLine("----------------------------------------");
                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine("{0,-10}\t{1,-10}\t{2,-10}", x1.Teacher, x1.Student, x1.Class);
                }
            }
        }
    }
}
