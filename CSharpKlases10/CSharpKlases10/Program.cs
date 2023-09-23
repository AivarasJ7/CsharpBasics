namespace CSharpKlases10
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Kompiuterių klasės: Sukurkite pagrindinę Computer klasę su savybėmis Brand ir Model ir metodu PrintComputerInfo(),
            // kuris išveda visą informaciją apie kompiuterį.
            // Tada sukurkite paveldėtą Laptop klasę su papildoma savybe BatteryLife ir papildomu metodu PrintLaptopInfo(),
            // kuris išveda informaciją apie nešiojamąjį kompiuterį. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.
            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė,
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            Console.WriteLine("Sveiki!");

            List<Computer> computers = new List<Computer>();

            while (true)
            {
                Console.WriteLine("Pasirinkite ka ivesite:");
                Console.WriteLine("1 - Stacionaru kompiuteri");
                Console.WriteLine("2 - nešiojamaji kompiuteri");
                Console.WriteLine("3 - baigti");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Computer computer = GetComputer();
                        computers.Add(computer);
                        break;
                    case "2":
                        Laptop laptop = GetLaptop();
                        computers.Add(laptop);
                        break;
                }

                if (userChoice == "3")
                {
                    break;
                }
            }

            PrintComputers(computers);
        }

        private static Computer GetComputer()
        {
            Console.WriteLine("Iveskite kompiuterio prekes zenkla: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Iveskite kompiuterio modeli: ");
            string model = Console.ReadLine();

            return new Computer(brand, model);
        }

        private static Laptop GetLaptop()
        {
            Console.WriteLine("Iveskite nesiojamojo kompiuterio prekes zenkla: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Iveskite nesiojamojo kompiuterio modeli: ");
            string model = Console.ReadLine();

            Console.WriteLine("Iveskite nesiojamojo kompiuterio baterijos veikimo laika (valandomis): ");
            int batteryLife = int.Parse(Console.ReadLine());

            return new Laptop(brand, model, batteryLife);
        }

        private static void PrintComputers(List<Computer> computers)
        {
            foreach (Computer computer in computers)
            {
                if (computer is Laptop laptop)
                {
                    laptop.PrintLaptopInfo();
                    Console.WriteLine($"Tai yra nesiojamas kompiuteris.");
                }
                else
                {
                    computer.PrintComputerInfo();
                    Console.WriteLine($"Tai yra stacionarus kompiuteris.");
                }

                Console.WriteLine();
            }
        }
    }
}