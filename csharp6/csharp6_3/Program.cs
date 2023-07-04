namespace csharp6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naudojant if sąlygas:
            //Užduotis 3: Patikrinti, ar duotas skaičius yra teigiamas ir dalinasi iš 3 arba 5.

            Random random = new Random();
            int number = random.Next(-50, 51);

            if (number > 0 && (number % 3 == 0 || number % 5 == 0))
            {
                Console.WriteLine($"Skaicius {number} yra teigiamas ir dalinasi is 3 arba 5"); //++
            }
            else if (number < 0 && (number % 3 == 0 || number % 5 == 0))
            {
                Console.WriteLine($"Skaicius {number} nera teigiamas bet dalinasi is 3 arba 5"); //-+
            }
            else if (number < 0 && (number % 3 != 0 || number % 5 != 0))
            {
                Console.WriteLine($"Skaicius {number} nera teigiamas ir nesidalina is 3 arba 5"); //--
            }
            else if (number > 0 && (number % 3 != 0 || number % 5 != 0))
            {
                Console.WriteLine($"Skaicius {number} yra teigiamas bet nesidalina is 3 arba 5"); // +-
            }
        }
    }
}