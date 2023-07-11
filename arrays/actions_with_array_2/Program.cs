namespace actions_with_array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uzpildyti masyva su atsitiktiniais skaiciais

            Random random = new Random();

            Console.WriteLine("Kokio dydzio masyvo jums reikia?");
            int arraySize = int.Parse(Console.ReadLine());

            int[] numbers = new int[arraySize];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}