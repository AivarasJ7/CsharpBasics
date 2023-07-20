namespace methods
{
    public class Calculator
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static void Divide(
            int divident, 
            int divisor, 
            out int quotient, 
            out int remainder) 
        { 
            quotient = divident / divisor;
            remainder = divident % divisor;
        }
    }
}
