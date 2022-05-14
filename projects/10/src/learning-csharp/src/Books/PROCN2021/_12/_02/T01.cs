namespace Luotao.LearningCsharp.Test.Books.PROCN2021._12._02
{
    namespace _01
    {
        /// <summary>
        /// 12.2.1. writing custom attributes
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
                [MyAttr01("", Age = 18, Name = "luotao")]
                void F01()
                {
                }

                F01();
            }
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
        class MyAttr01Attribute : Attribute
        {
            public string? Name { get; set; }

            public int Age { get; set; }

            public MyAttr01Attribute(string message)
            {
            }
        }
    }
}
