namespace Luotao.Lib.Books.ICS7._18._07
{
    /// <summary>
    ///     generic struct
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct PieceOfData<T> where T : struct
    {
        public T Data { get; set; }

        public PieceOfData(T value)
        {
            Data = value;
        }
    }
}
