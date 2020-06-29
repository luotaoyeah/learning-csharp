using System.Reflection;

namespace Luotao.Test.Books.CS10NET6._02._02._02._05
{
    /// <summary>
    ///     2.2.2.5 revealing the extent of the c# vocabulary
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
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly != null)
                foreach (AssemblyName referencedAssembly in entryAssembly.GetReferencedAssemblies())
                {
                    Assembly assembly = Assembly.Load(referencedAssembly.FullName);

                    var methodCount = 0;
                    foreach (var definedType in assembly.DefinedTypes) methodCount += definedType.GetMethods().Length;

                    testOutputHelper.WriteLine(
                        "{0,10:N0}\ttypes with {1,10:N0}\tmethods in {2}",
                        assembly.DefinedTypes.Count(),
                        methodCount,
                        referencedAssembly.Name
                    );
                }
        }
    }
}
