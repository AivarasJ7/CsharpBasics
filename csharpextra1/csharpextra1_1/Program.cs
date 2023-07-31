using System;

namespace csharpextra1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Standartiškai: Šiam assignment - vienas solution. Kiekviena užduotis tai atskiras projektas.
            // Po pirmos užduoties jau galit padaryti commit ir push, sukurti merge request,
            // o visas kitas pridėsite atskiru commit ir push.

            // 1.Liepkite vartotojui įvesti bet kokį tekstą.
            // Atspausdinkite ekrane žodžių, kurie prasideda raide "a" arba "A", skaičių.

            Console.WriteLine("Iveskite teksta:");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');

            int count = 0;

            foreach (string word in words)
            {
                if (word.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }

            Console.WriteLine($"Skaicius zodziu, kurie prasideda raide 'a' arba 'A': {count}");
        }
    }
}