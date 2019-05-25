namespace LT.BOOK.ICS7.C05.C0505
{
    /// <summary>
    /// 5.5. Creating Variables and Instances of A Class
    /// </summary>
    public class C0505
    {
        /// <summary>
        /// class(Foo) is reference type,
        /// so a class field's default value of type Foo is null
        /// </summary>
        private Foo Foo;

        /// <summary>
        /// 
        /// </summary>
        /// <returns><see cref="Foo"/></returns>
        public Foo Fn01()
        {
            return Foo;
        }
    }

    public class Foo
    {
    }
}