using System;

namespace Luotao.Test.Docs.Csharp.ProgrammingGuide.ClassesAndStructs.Destructors
{
  public class Car
  {
    public Car()
    {
      Console.WriteLine($"{nameof(Car)}.{nameof(Car)}()");
    }

    /// <summary>
    /// finalizer 由 GC 负责调用.
    /// </summary>
    ~Car()
    {
      Console.WriteLine($"{nameof(Car)}.~{nameof(Car)}()");
    }
  }
}
