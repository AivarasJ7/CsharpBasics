namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Liepkite vartotojui įvesti bet kokį simbolį.Atspausdinkite 3x3 kvadratą iš to simbolio.Pridėtas paveiksliukas.

            Console.Write("Įveskite simbolį: ");
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{symbol}{symbol}{symbol}");
            Console.WriteLine($"{symbol}{symbol}{symbol}");
            Console.WriteLine($"{symbol}{symbol}{symbol}");
        }
    }
}