namespace LuotaoYeah.Lib.Books.ICS7._06._13
{
    /// <summary>
    ///     6.13 reference types as value and reference parameters
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // reference 类型的参数作为 value parameter 传递，
        // reference 类型的参数作为 reference parameter 传递，
        //----------------------------------------------------------------------------------------------------

        public static void Fn01(Person person)
        {
            person = new Person { Age = 18 };
        }

        public static void Fn02(ref Person person)
        {
            person = new Person { Age = 18 };
        }
    }

    public class Person
    {
        public int Age;
    }
}
