using System;

namespace LuotaoYeah.Lib.Books.ICS7._16._02
{
    /// <summary>
    ///     interface 中可以包含 method/property/indexer/event
    /// </summary>
    public interface IMyInterface01
    {
        int Property01 { get; set; }
        int this[int index] { get; set; }
        int Method01();
        event EventHandler Event01;
    }
}
