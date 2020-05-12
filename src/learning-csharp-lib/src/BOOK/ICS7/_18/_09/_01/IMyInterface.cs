namespace LT.LIB.BOOK.ICS7._18._09._01
{
    public interface IMyInterface<T>
    {
        public T ReturnIt(T t);
    }

    /// <summary>
    /// non-generic interface 和 generic interface 可以同名，不会冲突
    /// </summary>
    public interface IMyInterface
    {
    }
}
