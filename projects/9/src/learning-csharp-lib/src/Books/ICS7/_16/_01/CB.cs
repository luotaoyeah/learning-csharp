namespace Luotao.Lib.Books.ICS7._16._01
{
    public class CB : IInfo
    {
        public string First;
        public string Last;
        public double PersonsAge;

        public string GetName()
        {
            return $"{First}{Last}";
        }

        public string GetAge()
        {
            return PersonsAge.ToString();
        }
    }
}
