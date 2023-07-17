namespace csharp19_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Užduotis 4: Pabandykite pridėti šalies pavadinimą, 
            //kuris jau yra HashSet, ir patikrinkite, ar šis pavadinimas buvo pridėtas (naudokite Add metodo grąžinamąją reikšmę). 
            // Parašykite ką grąžina Add metodas?

            HashSet<string> countries = new HashSet<string>()
            {
                "Lithuania",
                "Mexico",
                "Italy",
                "Columbia",
                "Germany",
            };

            if (!countries.Add("Lithuania"))
            {
                Console.WriteLine("Lithuania, jau buvo pridetas");
            }

            Console.WriteLine($"Add() metodas grazina {countries.Add("Lithuania")}");
        }
    }
}