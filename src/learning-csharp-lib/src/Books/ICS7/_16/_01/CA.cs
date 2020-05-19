namespace LuotaoYeah.Lib.Books.ICS7._16._01
{
    public class CA : IInfo
    {
        public int Age;
        public string Name;

        public string GetName()
        {
            return Name;
        }

        public string GetAge()
        {
            return Age.ToString();
        }
    }
}
