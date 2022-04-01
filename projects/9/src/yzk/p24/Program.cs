using System;
using System.Collections.Generic;
using System.Linq;

namespace P24;

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee() { Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000 });
        employees.Add(new Employee() { Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000 });
        employees.Add(new Employee() { Id = 3, Name = "lily", Age = 35, Gender = false, Salary = 9000 });
        employees.Add(new Employee() { Id = 4, Name = "lucy", Age = 16, Gender = false, Salary = 2000 });
        employees.Add(new Employee() { Id = 5, Name = "kimi", Age = 25, Gender = true, Salary = 1000 });
        employees.Add(new Employee() { Id = 6, Name = "nancy", Age = 35, Gender = false, Salary = 8000 });
        employees.Add(new Employee() { Id = 7, Name = "zack", Age = 35, Gender = true, Salary = 8500 });
        employees.Add(new Employee() { Id = 8, Name = "jack", Age = 33, Gender = true, Salary = 8000 });

        F01(employees);
        F02(employees);
        F03(employees);
    }

    /// <summary>
    /// Where().
    /// </summary>
    /// <param name="employees"></param>
    private static void F01(List<Employee> employees)
    {
        IEnumerable<Employee> enumerable = employees.Where(i => i.Age > 30);

        foreach (Employee employee in enumerable)
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Any().
    /// </summary>
    /// <param name="employees"></param>
    private static void F02(List<Employee> employees)
    {
        Console.WriteLine(employees.Any());
        Console.WriteLine(employees.Any(i => i.Name is "luotao"));
        Console.WriteLine();
        Console.WriteLine();
    }

    /// <summary>
    ///                     0         1        多
    /// ---------------------------------------------------
    /// Single()            报错      返回      报错
    /// SingleOrDefault()   返回默认   返回      报错
    /// First()             报错      返回      返回首条
    /// FirstOrDefault()    返回默认   返回      返回首条
    /// </summary>
    /// <param name="employees"></param>
    private static void F03(List<Employee> employees)
    {
        Console.WriteLine(employees.Single(i => i.Salary == 5000));
        Console.WriteLine(employees.SingleOrDefault(i => i.Salary == 10000, new Employee()));
        Console.WriteLine(employees.First(i => i.Gender));
        Console.WriteLine(employees.FirstOrDefault(i => i.Salary == 10000, new Employee()));

        Console.WriteLine();
        Console.WriteLine();
    }
}
