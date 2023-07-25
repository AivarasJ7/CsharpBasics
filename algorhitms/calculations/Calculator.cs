namespace calculations
{
    public class Calculator
    {
        public static int SumListNumbers(List<int> numbers)
        {
            if(numbers is null)
            {
                return 0;
            }
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}
