using static System.Formats.Asn1.AsnWriter;

namespace csharp6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naudojant if sąlygas:
            //Užduotis 2: Patikrinti, ar skaičius yra lyginis ir didesnis nei 10.

            Random random = new Random();
            int number = random.Next(1, 101);

            if (number % 2 == 0 && number > 10) //++
            {
                Console.WriteLine($"Skaicius {number} yra lyginis ir yra didesnis uz 10.");
            }
            else if (number % 2 == 0 && number < 10) //+-
            {
                Console.WriteLine($"Skaicius {number} yra lyginis bet nera didesnis uz 10.");
            }
            else if (number % 2 != 0 && number < 10) // --
            {
                Console.WriteLine($"Skaicius {number} nera lyginis ir nera didesnis uz 10.");
            }
            else if (number % 2 != 0 && number > 10) // -+
            {
                Console.WriteLine($"Skaicius {number} nera lyginis bet yra didesnis uz 10.");
            }
        }
    }
}