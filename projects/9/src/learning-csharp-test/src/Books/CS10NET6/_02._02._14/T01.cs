using System.Reflection;

namespace Luotao.Test.Books.CS10NET6._02._02._14
{
    /// <summary>
    /// 2.2.14. revealing the extent of the c# vocabulary
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
            Assembly? entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly == null)
            {
                return;
            }

            AssemblyName[] referencedAssemblies = entryAssembly.GetReferencedAssemblies();
            foreach (AssemblyName name in referencedAssemblies)
            {
                Assembly assembly = Assembly.Load(name);
                IEnumerable<TypeInfo> types = assembly.DefinedTypes;

                int methodCount = 0;
                foreach (TypeInfo type in types)
                {
                    methodCount += type.GetMethods().Length;
                }

                testOutputHelper.WriteLine($"{name.Name}:\n{assembly.GetTypes().Length,10:N0} Type\n{methodCount,10:N0} Method\n");
            }
        }
    }
}
