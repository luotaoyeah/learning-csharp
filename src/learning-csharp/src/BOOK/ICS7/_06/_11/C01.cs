namespace LT.BOOK.ICS7._06._11
{
    /// <summary>
    /// 6.11 value parameters
    /// </summary>
    public class C01
    {
        public static void Fn01(Person person, int x)
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
