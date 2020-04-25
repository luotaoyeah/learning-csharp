namespace LT.BOOK.ICS7._13._14
{
    public class C01
    {
        public static ref int PointerToHighestPositive(int[] numbers)
        {
            int highest = 0;
            int indexOfHighest = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                    indexOfHighest = i;
                }
            }

            return ref numbers[indexOfHighest];
        }
    }
}
