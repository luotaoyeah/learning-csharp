namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._06
{
    namespace _00
    {
        /// <summary>
        /// 3.6. enum types
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
                // 默认从 0 开始递增
                Assert.Equal(0, (int)E01.A);
                Assert.Equal(1, (int)E01.B);
                Assert.Equal(2, (int)E01.C);
            }

            [Fact]
            public void _02()
            {
                Assert.Equal(10, (int)E02.A);
                Assert.Equal(20, (int)E02.B);
                Assert.Equal(21, (int)E02.C);
            }

            [Fact]
            public void _03()
            {
                E04 e04 = E04.A | E04.C;
                Assert.Equal(5, (byte)e04);
                Assert.Equal("A, C", e04.ToString());
            }
        }

        enum E01
        {
            A,
            B,
            C
        }

        enum E02
        {
            // 自己指定数值
            A = 10,
            B = 20,
            C
        }

        // 自己指定类型, 必须是整型(byte/short/int/long)
        enum E03 : short
        {
            A = 1,
            B = 2,
            C = 3
        }

        [Flags]
        enum E04
        {
            A = 0b00000001,
            B = 0b00000010,
            C = 0b00000100,
        }
    }
}
