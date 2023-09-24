namespace CSharpKlases11
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Statinių klasės: Sukurkite bazinę klasę Building su savybėmis Address ir NumberOfFloors ir metodu PrintBuildingInfo(),
            // kuris išveda visą informaciją apie pastatą.
            // Tada sukurkite paveldėtą klasę ResidentialBuilding su papildoma savybe NumberOfApartments ir papildomu metodu PrintResidentialBuildingInfo(),
            // kuris išveda informaciją apie gyvenamąjį namą. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė, o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            List<Building> buildings = new List<Building>();

            Console.WriteLine("Sveiki!");

            while (true)
            {
                Console.WriteLine("Pasirinkite, ką darysite:");
                Console.WriteLine("1 - Prideti nauja pastata");
                Console.WriteLine("2 - Prideti nauja gyvenamaji nama");
                Console.WriteLine("3 - Baigti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Building newBuilding = AddNewBuilding();
                        buildings.Add(newBuilding);
                        break;

                    case 2:
                        ResidentialBuilding newResidentialBuilding = AddNewResidentialBuilding();
                        buildings.Add(newResidentialBuilding);
                        break;

                    case 3:
                        DisplayBuildingInfo(buildings);
                        return;

                    default:
                        Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar karta.");
                        break;
                }
            }
        }

        private static Building AddNewBuilding()
        {
            Console.WriteLine("Iveskite pastato adresa: ");
            string address = Console.ReadLine();
            Console.WriteLine("Iveskite pastato aukstu skaiciu: ");
            int numberOfFloors = int.Parse(Console.ReadLine());

            return new Building(address, numberOfFloors);
        }

        private static ResidentialBuilding AddNewResidentialBuilding()
        {
            Console.WriteLine("Iveskite gyvenamojo namo adresa: ");
            string address = Console.ReadLine();
            Console.WriteLine("Iveskite gyvenamojo namo aukstu skaiciu: ");
            int numberOfFloors = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite gyvenamojo namo butu skaiciu: ");
            int numberOfApartments = int.Parse(Console.ReadLine());

            return new ResidentialBuilding(address, numberOfFloors, numberOfApartments);
        }

        private static void DisplayBuildingInfo(List<Building> buildings)
        {
            Console.WriteLine("Informacija apie pastatus:");
            foreach (Building building in buildings)
            {
                if (building is ResidentialBuilding residentialBuilding)
                {
                    residentialBuilding.PrintResidentialBuildingInfo();
                }
                else
                {
                    building.PrintBuildingInfo();
                }
            }
        }
    }
}