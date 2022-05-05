namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._02;

/// <summary>
/// 3.2. pass by value or by reference
/// </summary>
public class T00
{
    private readonly ITestOutputHelper testOutputHelper;

    public T00(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _01()
    {
        StructA s01 = new StructA() { ClassA = new ClassA() { X = 6 } };
        StructA s02 = s01;

        s02.ClassA.X = 8;
        Assert.Equal(8, s01.ClassA.X);

        s02.ClassA = new ClassA() { X = 9 };
        Assert.Equal(8, s01.ClassA.X);
    }

    [Fact]
    public void _02()
    {
        ClassB s01 = new ClassB() { ClassA = new ClassA() { X = 6 } };
        ClassB s02 = s01;

        s02.ClassA.X = 8;
        Assert.Equal(8, s01.ClassA.X);

        s02.ClassA = new ClassA() { X = 9 };
        Assert.Equal(9, s01.ClassA.X);
    }
}

struct StructA
{
    public ClassA ClassA;
}

class ClassA
{
    public int X;
}

class ClassB
{
    public ClassA? ClassA;
}
