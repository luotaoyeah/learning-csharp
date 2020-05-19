using System.Collections.Generic;
using LuotaoYeah.Lib.Books.ICS7._10._09._02;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._10._09._02
{
    /// <summary>
    ///     10.9.2 other types of pattern expressions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle { Radius = 7 });
            shapes.Add(new Square { Side = 5 });
            shapes.Add(new Square { Side = 20 });
            shapes.Add(new Triangle { Height = 4 });

            foreach (var shape in shapes)
                switch (shape)
                {
                    //----------------------------------------------------------------------------------------------------
                    // case 后面的表达式叫做 pattern expression，
                    // case 可以匹配一个 value，也可以匹配一个 type，
                    // 即判断 matching expression 是否是 pattern expression 指定的类型，
                    //----------------------------------------------------------------------------------------------------
                    case Circle circle:
                        testOutputHelper.WriteLine($"{nameof(Circle)}: {circle.Radius}");
                        break;
                    //----------------------------------------------------------------------------------------------------
                    // pattern expression 中可以使用 when 来定义一个 filter
                    //----------------------------------------------------------------------------------------------------
                    case Square square when square.Side > 10:
                        testOutputHelper.WriteLine($"{nameof(Square)}: {square.Side}");
                        break;
                    //----------------------------------------------------------------------------------------------------
                    // 如果 case 块里面有 statement，则必须使用 break/continue/return/goto/throw 来跳出，
                    //----------------------------------------------------------------------------------------------------
                    case Triangle triangle:
                        testOutputHelper.WriteLine($"{nameof(Triangle)}: {triangle.Height}");
                        break;
                }
        }
    }
}
