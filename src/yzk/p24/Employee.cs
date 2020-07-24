namespace P24;

public class Employee
{
    public long Id { get; set; }

    /// <summary>
    /// 姓名.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 年龄.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// 性别.
    /// </summary>
    public bool Gender { get; set; }

    /// <summary>
    /// 月薪.
    /// </summary>
    public int Salary { get; set; }

    public override string ToString()
    {
        return
            $"{"Id",-4}{"Name",-10}{"Age",-10}{"Gender",-10}{"Salary",-10}\n" +
            $"{Id,-4}{Name,-10}{Age,-10}{Gender,-10}{Salary,-10}\n" +
            "--------------------------------------------\n";
    }
}
