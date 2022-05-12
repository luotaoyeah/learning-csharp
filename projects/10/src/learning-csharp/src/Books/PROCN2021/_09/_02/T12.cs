using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _12
    {
        /// <summary>
        /// 9.2.12. set operations
        /// </summary>
        public class T12
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T12(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var list01 = new List<int>() { 1, 2, 3, };
                var list02 = new List<int>() { 2, 3, 4 };

                // 交集
                IEnumerable<int> intersect = list01.Intersect(list02);

                foreach (int i in intersect)
                {
                    testOutputHelper.WriteLine("{0}", i);
                }

                testOutputHelper.WriteLine("----------");

                // 并集
                IEnumerable<int> union = list01.Union(list02);

                foreach (int i in union)
                {
                    testOutputHelper.WriteLine("{0}", i);
                }

                testOutputHelper.WriteLine("----------");

                // 差集
                IEnumerable<int> except = list01.Except(list02);

                foreach (int i in except)
                {
                    testOutputHelper.WriteLine("{0}", i);
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

                testOutputHelper.WriteLine("{0,-10}\t\t{1,-10}\t{2,-10}", "老师", "班级", "学生");
                testOutputHelper.WriteLine("----------------------------------------");
                foreach (var x1 in query)
                {
                    testOutputHelper.WriteLine("{0,-10}\t{1,-10}\t{2,-10}", x1.Teacher, x1.Class, x1.Student);
                }
            }
        }
    }
}
