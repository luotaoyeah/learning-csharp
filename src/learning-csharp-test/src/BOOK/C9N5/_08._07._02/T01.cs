using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._08._07._02
{
    /// <summary>
    ///     8.7.2 reading assembly metadata
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
            var assembly = Assembly.GetExecutingAssembly();

            var assemblyCompanyAttribute = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            Assert.Equal("luotao", assemblyCompanyAttribute?.Company);

            var assemblyInformationalVersionAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            Assert.Equal("1.0.0", assemblyInformationalVersionAttribute?.InformationalVersion);

            Assert.Equal("learning-csharp-test", assembly.GetName().Name);
        }
    }
}
