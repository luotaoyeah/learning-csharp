namespace Luotao.Lib.Books.ICS7._06._12
{
    /// <summary>
    ///     6.12 reference parameters
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // 使用 ref 声明一个 reference parameter，
        // reference parameter 类似于 C++ 里面的 reference，只是一个变量别名，
        //----------------------------------------------------------------------------------------------------
        public static void Fn01(ref Person person, ref int x)
        {
            person.Age += 1;
            x += 1;
        }
    }

    public class Person
    {
        public int Age;
    }
}
