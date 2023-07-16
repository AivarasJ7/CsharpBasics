using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais skaičiais nuo 1 iki 100.

            List<int> randomList = new List<int>();

            Random random = new Random();

            int randomListSize = random.Next(1, 11);

            for (int i = 0; i < randomListSize; i++)
            {
                int number = random.Next(1, 101);
                randomList.Add(number);
            }

            Console.WriteLine("Atsitiktinis sarasas:");

            foreach (int number in randomList)
            {
                Console.WriteLine(number);
            }

            // Raskite: 
            //1.1.mažiausią skaičių;

            Console.WriteLine($"Maziausias skaicius: {randomList.Min()}");

            // 1.2.didžiausią skaičių;

            Console.WriteLine($"Didziausias skaicius: {randomList.Max()}");

            // 1.3.vidurkį;

            Console.WriteLine($"Didziausias skaicius: {randomList.Average()}");

            // 1.4.kiek skaičių yra žemesni už vidurkį;

            int count = 0;

            foreach (int number in randomList)
            {
                if (number < randomList.Average())
                {
                    count++;
                }
            }

            Console.WriteLine($"Skaiciu esanciu zemiau uz vidurki kiekis {count}");

            // 1.5.lyginių skaičių sumą

            Console.WriteLine($"Lyginiu skaiciu suma: {randomList.Where(number => number % 2 == 0).Sum()}");
        }
    }
}