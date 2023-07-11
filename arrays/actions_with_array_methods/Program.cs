namespace actions_with_array_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            Console.Write("Suma: ");
            Console.WriteLine(numbers.Sum());

            Console.Write("Didziausias: ");
            Console.WriteLine(numbers.Max());

            Console.Write("Maziasias: ");
            Console.WriteLine(numbers.Min());

            Console.Write("Vidurkis: ");
            Console.WriteLine(numbers.Average());
        }
    }
}