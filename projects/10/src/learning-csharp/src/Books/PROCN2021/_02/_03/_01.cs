using System.Numerics;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._03;

/// <summary>
/// 2.3.1. integer types
/// </summary>
public class _01
{
    private readonly ITestOutputHelper testOutputHelper;

    public _01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// integer types.
    /// </summary>
    [Fact]
    public void _02()
    {
        // byte
        byte b01 = 1;
        Byte b02 = 1;
        Assert.Equal(b01, b02);

        // sbyte
        sbyte sb01 = -1;
        SByte sb02 = -1;
        Assert.Equal(sb01, sb02);

        // short
        short s01 = -1;
        Int16 s02 = -1;
        Assert.Equal(s01, s02);

        // ushort
        ushort us01 = 1;
        UInt16 us02 = 1;
        Assert.Equal(us01, us02);

        // int
        int i01 = -1;
        Int32 i02 = -1;
        Assert.Equal(i01, i02);

        // uint
        uint ui01 = 1;
        UInt32 ui02 = 1;
        Assert.Equal(ui01, ui02);

        // long
        long l01 = -1;
        Int64 l02 = 1;
        Assert.Equal(l01, l02);

        // ulong
        ulong ul01 = 1;
        UInt64 ul02 = 1;
        Assert.Equal(ul01, ul02);
    }

    /// <summary>
    /// BigInteger.
    /// </summary>
    [Fact]
    public void _03()
    {
        // 表示任意位的整数
        BigInteger i01 = 1;
        Assert.Equal(i01, 1);
    }

    /// <summary>
    /// floating-point types.
    /// </summary>
    [Fact]
    public void _04()
    {
        float f01 = 3.14f;
        Single f02 = 3.14F;
        Assert.Equal(f01, f02);

        double d01 = 3.14d;
        Double d02 = 3.14D;
        Assert.Equal(d01, d02);

        decimal de01 = 3.14m;
        Decimal de02 = 3.14M;
        Assert.Equal(de01, de02);
    }

    /// <summary>
    /// boolean type.
    /// </summary>
    [Fact]
    public void _05()
    {
        bool b01 = true;
        Boolean b02 = true;
        Assert.Equal(b01, b02);
    }

    /// <summary>
    ///  string / object.
    /// </summary>
    [Fact]
    public void _06()
    {
        string str01 = "foo";
        String str02 = "foo";
        Assert.Equal(str01, str02);

        object o01 = true;
        Object o02 = true;
        Assert.Equal(o01, o02);
    }
}
