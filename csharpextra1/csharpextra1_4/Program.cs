using System.Reflection.Metadata;

namespace csharpextra1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Liepkite vartotojui įvesti bet kokį tekstą. Atspausdinkite ekrane visų balsių ir priebalsių kiekį tekste. Pvz.:
            // Įvestas tekstas: "labas"
            // Balsių kiekis: 2
            // Priebalsių kiekis: 3

            Console.WriteLine("Iveskite teksta:");
            string text = Console.ReadLine().ToLower();

            int vowelCount = 0;
            int consonantCount = 0;

            foreach (char symbol in text)
            {
                if (Char.IsLetter(symbol))
                {
                    if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine($"Balsių kiekis: {vowelCount}");
            Console.WriteLine($"Priebalsių kiekis: {consonantCount}");
        }
    }
}