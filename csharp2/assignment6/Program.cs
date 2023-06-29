using System.Diagnostics.Metrics;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string make = "BMW";
            string model = "525i";
            int year = 2003;
            double mileage = 150199;

            Console.WriteLine($"Automobilio {make} {model} ({year} m.) rida - {mileage} km");
        }
    }
}