namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._04
{
    namespace _02
    {
        /// <summary>
        /// 3.4.2. nominal records
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            // 重写了 ToString()
            [Fact]
            public void _01()
            {
                R01 r01 = new() { Age = 18 };
                Assert.Equal("R01 { Age = 18 }", r01.ToString());

                C01 c01 = new() { Age = 18 };
                Assert.Equal("Luotao.LearningCsharp.Test.Books.PROCN2021._03._04._02.C01", c01.ToString());
            }

            // 重写了 == , != , Equals(), 比较的是对象的属性, 而不是比较对象的引用
            [Fact]
            public void _02()
            {
                R01 r01 = new() { Age = 18 };
                R01 r02 = new() { Age = 18 };

                C01 c01 = new() { Age = 18 };
                C01 c02 = new() { Age = 18 };

                Assert.True(r01 == r02);
                Assert.False(c01 == c02);

                Assert.True(r01.Equals(r02));
                Assert.False(c01.Equals(c02));

                Assert.False(r01 != r02);
                Assert.True(c01 != c02);
            }
        }

        public record R01
        {
            public int Age { get; set; }
        }

        public class C01
        {
            public int Age { get; set; }
        }
    }
}
