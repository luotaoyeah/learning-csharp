using System;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.C9N5._08._07._03
{
    /// <summary>
    ///     8.7.3 creating custom attributes
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
            var type = typeof(C01);
            var customAttributes = type.GetCustomAttributes<CoderAttribute>();
            foreach (var customAttribute in customAttributes) testOutputHelper.WriteLine(customAttribute.Coder);
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CoderAttribute : Attribute
    {
        public string? Coder;

        public CoderAttribute(string? coder)
        {
            Coder = coder;
        }
    }

    [Coder("luotao")]
    [Coder("owen")]
    public class C01
    {
        [Coder("luotao")]
        public static void F01()
        {
        }
    }
}
