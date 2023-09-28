namespace CSharpKlases14
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Augalų klasės: Sukurkite bazinę klasę Plant su savybėmis Species ir Height ir metodu PrintPlantInfo(), kuris išveda visą informaciją apie augalą.
            // Tada sukurkite paveldėtą klasę Flower su papildoma savybe Color ir papildomu metodu PrintFlowerInfo(), kuris išveda informaciją apie gėlę.
            // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė, o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją

            List<Plant> plants = new List<Plant>();

            Console.WriteLine("Sveiki!");

            while (true)
            {
                Console.WriteLine("Pasirinkite, ką darysite:");
                Console.WriteLine("1 - Prideti nauja augala");
                Console.WriteLine("2 - Prideti nauja gele");
                Console.WriteLine("3 - Baigti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Plant newPlant = AddNewPlant();
                        plants.Add(newPlant);
                        break;

                    case 2:
                        Flower newFlower = AddNewFlower();
                        plants.Add(newFlower);
                        break;

                    case 3:
                        DisplayPlantInfo(plants);
                        return;

                    default:
                        Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar karta.");
                        break;
                }
            }
        }

        private static Plant AddNewPlant()
        {
            Console.WriteLine("Iveskite augalo rusi: ");
            string species = Console.ReadLine();

            Console.WriteLine("ĮIveskite augalo auksti (cm): ");
            int height = int.Parse(Console.ReadLine());

            return new Plant(species, height);
        }

        private static Flower AddNewFlower()
        {
            Console.WriteLine("Iveskite geles rusi: ");
            string species = Console.ReadLine();

            Console.WriteLine("Iveskite geles auksti (cm): ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite geles spalva: ");
            string color = Console.ReadLine();

            return new Flower(species, height, color);
        }

        private static void DisplayPlantInfo(List<Plant> plants)
        {
            Console.WriteLine("Informacija apie augalus ir geles:");
            foreach (Plant plant in plants)
            {
                if (plant is Flower flower)
                {
                    Console.WriteLine(flower.PrintFlowerInfo());
                }
                else
                {
                    Console.WriteLine(plant.PrintPlantInfo());
                }
            }
        }
    }
}