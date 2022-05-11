namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

public class Teacher
{
    /// <summary>
    /// 老师姓名.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 班级.
    /// </summary>
    public string Class { get; set; }

    /// <summary>
    /// 老师列表.
    /// </summary>
    public static List<Teacher> Teachers()
    {
        return new List<Teacher>()
        {
            new() { Name = "张老师", Class = "A" },
            new() { Name = "李老师", Class = "B" },
            new() { Name = "王老师", Class = "C" },
        };
    }
}
