namespace pair_programming2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7. (optional) Be daugybos veiksmo programoje, sudauginti du skaičius.

            Random random = new Random();
            int number1 = random.Next(1, 99);
            int number2 = random.Next(1, 99);

            Console.WriteLine($"Random skaicius 1 - {number1}");
            Console.WriteLine($"Random skaicius 2 - {number2}");

            int result = 0;

            for (int i = 0; i < number2; i++)
            {
                result += number1;
            }

            Console.WriteLine(result);
        }
    }
}