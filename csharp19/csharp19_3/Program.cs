namespace csharp19_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 3: Sukurti HashSet su šalių pavadinimais ir atspausdinti jų kiekį.

            HashSet<string> countries = new HashSet<string>()
            {
                "Lithuania",
                "Mexico",
                "Italy",
                "Columbia",
                "Germany",
            };

            Console.WriteLine($"Saliu kiekis: {countries.Count}");
        }
    }
}