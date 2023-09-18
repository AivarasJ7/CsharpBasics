namespace CSharpKlases5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Transporto priemonių klasės: Sukurkite pagrindinę Vehicle klasę su savybėmis Brand, Model ir Year ir metodu PrintInfo(),
            // kuris išveda visą informaciją apie transporto priemonę.
            // Tada sukurkite paveldėtą Car klasę su papildoma savybe NumberOfSeats ir papildomu metodu PrintCarInfo(), kuris išveda informaciją apie automobilį.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė,
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.Pavyzdžiui, vartotojas galėtų pasirinkti, ar nori pridėti naują automobilį,
            // o programa pagal įvestus duomenis sukurtų Car objektą ir pridėtų jį prie Vehicle sąrašo.

            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            Console.WriteLine("Sveiki, atvyke!");

            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                Console.WriteLine("Pasirinkite, ka darysite:");
                Console.WriteLine("1 - Prideti nauja transporto priemone");
                Console.WriteLine("2 - Baigti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Iveskite transporto priemones marke: ");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Iveskite transporto priemones modeli: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Iveskite transporto priemones pagaminimo metus: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ar tai yra automobilis? (t/n): ");
                        string isCarInput = Console.ReadLine().ToLower();

                        if (isCarInput == "t")
                        {
                            Console.WriteLine("Iveskite automobilio sedimu vietu skaiciu: ");
                            int numberOfSeats = int.Parse(Console.ReadLine());
                            Car newCar = new Car(brand, model, year, numberOfSeats);
                            vehicles.Add(newCar);
                        }
                        else if (isCarInput == "n")
                        {
                            Vehicle newVehicle = new Vehicle(brand, model, year);
                            vehicles.Add(newVehicle);
                        }
                        else
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar karta.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Informacija apie transporto priemones:");
                        foreach (var vehicle in vehicles)
                        {
                            if (vehicle is Car car)
                            {
                                Console.WriteLine(car.PrintCarInfo());
                            }
                            else
                            {
                                Console.WriteLine(vehicle.PrintInfo());
                            }
                        }
                        return;

                    default:
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                        }
                        break;
                }
            }
        }
    }
}