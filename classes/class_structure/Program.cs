namespace class_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            while (true)
            {
                Console.WriteLine("Uzregistruoti automobili");
                Car car = new Car();

                Console.Write("Iveskite auto marke:");
                car.Brand = Console.ReadLine();

                Console.Write("Iveskite auto modeli");
                car.Model = Console.ReadLine();

                Console.Write("Iveskite auto metus:");
                car.Year = int.Parse(Console.ReadLine());

                Console.Write("Iveskite auto rida:");
                car.Mileage = int.Parse(Console.ReadLine());

                cars.Add(car);

                Console.WriteLine("Ar norite testi t/n?");
                string choice = Console.ReadLine();

                if(choice != "t")
                {
                    break;
                }
            }

            foreach (Car car in cars)
            {
                PrintCarInfo(car);
            }
        }

        private static void PrintCarInfo(Car car)
        {
            Console.WriteLine();
            Console.WriteLine($"Ivestas automobilis {car.Brand}");
            Console.WriteLine($"Modelis: {car.Model}");
            Console.WriteLine($"Metai: {car.Year}");
            Console.WriteLine($"Rida: {car.Mileage}");
            Console.WriteLine($"Vidutiniskai per metus nuvaziuota: {car.CalculateKilometersPerYear()}");
        }
    }
}