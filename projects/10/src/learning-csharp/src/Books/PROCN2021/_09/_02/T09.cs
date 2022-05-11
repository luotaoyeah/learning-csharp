using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _09
    {
        /// <summary>
        /// 9.2.9. inner join
        /// </summary>
        public class T09
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T09(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var query = from t in Teacher.Teachers()
                    join s in Student.Students()
                        on t.Class equals s.Class
                    select new
                    {
                        Teacher = t.Name,
                        Student = s.Name,
                        Class = s.Class,
                    };

                testOutputHelper.WriteLine("老师\t\t学生\t\t班级");
                testOutputHelper.WriteLine("--------------------");
                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine($"{x1.Teacher}\t{x1.Student}\t\t{x1.Class}");
                }
            }

            [Fact]
            public void _02()
            {
                var query = Teacher.Teachers()
                    .Join(Student.Students(), t => t.Class, s => s.Class, (t, s) => new { Teacher = t.Name, Student = s.Name, Class = s.Class, });

                testOutputHelper.WriteLine("老师\t\t学生\t\t班级");
                testOutputHelper.WriteLine("--------------------");
                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine($"{x1.Teacher}\t{x1.Student}\t\t{x1.Class}");
                }
            }
        }
    }
}
