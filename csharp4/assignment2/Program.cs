namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite simbolį: ");
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{symbol}{symbol}{symbol}");
            Console.WriteLine($"{symbol}{symbol}{symbol}");
            Console.WriteLine($"{symbol}{symbol}{symbol}");
        }
    }
}