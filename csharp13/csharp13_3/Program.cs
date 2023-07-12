namespace csharp13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Susikurkite kintamąjį, kuris pasakytų kokia yra automobilio bako talpa.

            int fuelTankCapacity = 65;

            // Susikurkite masyvą, kuriame saugotumėte skirtingose kelionėse nuvažiuotų kilometrų rodmenis.
            // Masyvo elementų skaičius tai kartai kiek automobilis gali nuvažiuoti su pilnu baku.

            double[] trips = { 320, 270, 100 };

            //Raskite:
            // 3.1.trumpiausią kelionę;

            Console.WriteLine($"Trumpiausia kelione: {trips.Min()}");

            // 3.2.ilgiausią kelionę;

            Console.WriteLine($"Ilgiausia kelione: {trips.Max()}");

            // 3.3.kiek vidutiniškai kuro sąnaudų sunaudojo automobilis kiekvienos kelionės metu;

            double totalFuelConsumption = trips.Sum();

            Console.Write($"Vidutiniškai kuro sąnaudų sunaudojo automobilis kiekvienos kelionės metu: {totalFuelConsumption / fuelTankCapacity}");
        }
    }
}