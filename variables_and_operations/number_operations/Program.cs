namespace number_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // additions
            int sum = 10 + 5;

            int number1 = 5;
            int number2 = 15;
            int sum2 = number1 + number2;

            //subtraction

            int substraction = number1 - number2;

            //multiplication
            int multiplication = number1 * number2;

            //division
            //simple division
            number1 = 3;
            number2 = 10;
            decimal division = (decimal)number2 / number1;

            //module division
            int moduleDivision = 10 % 3;

            //combined operations
            decimal result = number1 + number2 * (decimal)number1 / number2;
            decimal result2 = (number1 + number2) * (decimal)number1 / number2;
        }
    }
}