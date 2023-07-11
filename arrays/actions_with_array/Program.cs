namespace actions_with_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kaip atrinkti lyginius skaicius is masyvo?

            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Lyginiai skaiciai yra sie: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}