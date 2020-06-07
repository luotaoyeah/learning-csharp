namespace Luotao.Test.Docs.Csharp.LanguageReference.Keywords.init
{
    public class InitExample
    {
        public InitExample()
        {
        }

        public InitExample(double seconds)
        {
            Seconds = seconds;
        }

        /// <summary>
        /// init accessor 跟 set accessor 的区别是: init accessor 只能在 object initializer 或者 constructor 参数中赋值.
        /// </summary>
        public double Seconds { get; init; }

        /// <summary>
        /// indexer 中也可以定义 init accessor.
        /// </summary>
        /// <param name="index">index.</param>
        public double this[int index]
        {
            get => Seconds;
            init => Seconds = value;
        }
    }
}
