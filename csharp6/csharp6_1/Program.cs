namespace csharp6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naudojant if sąlygas:
            //Užduotis 1: Patikrinti, ar skaičius yra didesnis nei 50.

            Random random = new Random();
            int number = random.Next(1, 101);

            if (number > 50)
            {
                Console.WriteLine($"Skaičius {number} yra didesnis nei 50.");
            }
            else
            {
                Console.WriteLine($"Skaičius {number} nera didesnis nei 50.");
            }
        }
    }
}