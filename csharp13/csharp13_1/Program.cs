namespace csharp13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Susikurkite savaitės temperatūrų rodmenų masyvą. Raskite:

            double[] weekTemperatures = { 22, 20, 26, 25, 24, 26, 21 };

            // 1.1.žemiausią temperatūrą;

            Console.Write("Savaites žemiausia temperatura: ");
            Console.WriteLine(weekTemperatures.Min());

            // 1.2.didžiausią temperatūrą;

            Console.Write("Savaites didziausia temperatura: ");
            Console.WriteLine(weekTemperatures.Max());

            // 1.3.vidurkį;

            Console.Write("Savaites temperaturos vidurkis: ");
            Console.WriteLine(weekTemperatures.Average());

            // 1.4.temperatūrų esančių žemiau už vidurkį kiekį;

            double weekTemperatureAverage = weekTemperatures.Average();

            int count = 0;

            foreach (double weektemperature in weekTemperatures)
            {
                if (weektemperature < weekTemperatureAverage)
                {
                    count++;
                }
            }

            Console.WriteLine($"Temperaturu esanciu zemiau uz vidurki kiekis {count}");

            // 1.5.temperatūrų esančių aukščiau už vidurkį kiekį;

            double weekTemperatureAverage2 = weekTemperatures.Average();
            
            int count2 = 0;

            foreach (double weektemperature in weekTemperatures)
            {
                if (weektemperature > weekTemperatureAverage2)
                {
                    count2++;
                }
            }

            Console.WriteLine($"Temperaturu esanciu auksciau uz vidurki kiekis: {count2}");
        }
    }
}