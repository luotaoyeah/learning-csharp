namespace Luotao.Lib.Books.ICS7._18._09._01
{
    /// <summary>
    ///     同一个 generic interface 使用不同的 type parameter 时，相当于两个不同的 interface，
    /// </summary>
    public class Simple : IMyInterface<int>, IMyInterface<string>
    {
        public int ReturnIt(int t)
        {
            return t;
        }

        public string ReturnIt(string t)
        {
            return t;
        }
    }
}
