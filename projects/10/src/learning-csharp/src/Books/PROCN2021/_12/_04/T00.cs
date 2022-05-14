using System.Reflection;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._12._04
{
    namespace _00
    {
        /// <summary>
        /// 12.4. using dynamic language extensions for reflection
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
                object? calculator = GetCalculator();

                MethodInfo? add = calculator?.GetType().GetMethod("Add");
                Assert.Equal(3, add?.Invoke(calculator, new object?[] { 1, 2 }));

                MethodInfo? subtract = calculator?.GetType().GetMethod("Subtract");
                Assert.Equal(-1, subtract?.Invoke(calculator, new object?[] { 1, 2 }));
            }

            [Fact]
            public void _02()
            {
                dynamic? calculator = GetCalculator();

                Assert.Equal(3, calculator?.Add(1, 2));

                Assert.Equal(-1, calculator?.Subtract(1, 2));
            }

            private object? GetCalculator()
            {
                const string path = @"D:\proj\github\luotaoyeah\learning-csharp\projects\10\src\CalculatorLibrary\bin\Debug\net6.0\CalculatorLibrary.dll";
                Assembly assembly = Assembly.LoadFile(path);
                object? calculator = assembly.CreateInstance("CalculatorLibrary.Calculator");
                return calculator;
            }
        }
    }
}
