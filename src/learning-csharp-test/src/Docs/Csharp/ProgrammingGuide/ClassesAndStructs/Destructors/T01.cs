using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Docs.Csharp.ProgrammingGuide.ClassesAndStructs.Destructors
{
  /// <summary>
  /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/destructors#remarks.
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
      var car = new Car();
      car = null;

      GC.Collect();
      GC.WaitForPendingFinalizers();
    }
  }
}
