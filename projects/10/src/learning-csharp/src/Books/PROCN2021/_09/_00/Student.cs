namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

public class Student
{
    /// <summary>
    /// 学生姓名.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 班级.
    /// </summary>
    public string Class { get; set; }

    public static List<Student> Students()
    {
        return new List<Student>()
        {
            new Student() { Name = "小明", Class = "B" },
            new Student() { Name = "小红", Class = "C" },
            new Student() { Name = "小花", Class = "D" },
        };
    }
}
