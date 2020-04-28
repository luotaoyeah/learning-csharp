namespace LT.BOOK.ICS7._18._07
{
    /// <summary>
    /// generic struct
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct PieceOfData<T> where T : struct
    {
        private T _data;

        public T Data
        {
            get => _data;
            set => _data = value;
        }

        public PieceOfData(T value)
        {
            _data = value;
        }
    }
}
