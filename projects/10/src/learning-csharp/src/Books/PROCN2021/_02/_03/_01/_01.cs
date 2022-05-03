namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._03._01;

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

    [Fact]
    public void _02()
    {
        // byte
        byte b01 = 1;
        System.Byte b02 = 1;
        Assert.Equal(b01, b02);

        // sbyte
        sbyte sb01 = -1;
        System.SByte sb02 = -1;
        Assert.Equal(sb01, sb02);

        // short
        short s01 = -1;
        System.Int16 s02 = -1;
        Assert.Equal(s01, s02);

        // ushort
        ushort us01 = 1;
        System.UInt16 us02 = 1;
        Assert.Equal(us01, us02);

        // int
        int i01 = -1;
        System.Int32 i02 = -1;
        Assert.Equal(i01, i02);

        // uint
        uint ui01 = 1;
        System.UInt32 ui02 = 1;
        Assert.Equal(ui01, ui02);

        // long
        long l01 = -1;
        System.Int64 l02 = 1;
        Assert.Equal(l01, l02);

        // ulong
        ulong ul01 = 1;
        System.UInt64 ul02 = 1;
        Assert.Equal(ul01, ul02);
    }
}
