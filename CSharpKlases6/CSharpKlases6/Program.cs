namespace CSharpKlases6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Gyvūnų klasės: Sukurkite bazinę klasę Animal su savybėmis Name ir Age ir metodu MakeSound(), kuris imituoja gyvūno garsą.
            // Tada sukurkite paveldėtas klases Dog ir Cat, kurios prideda papildomas savybes, tokias kaip Breed ir Color atitinkamai, bei perrašo MakeSound() metodą.
            // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė,
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas. 

            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            Console.WriteLine("Sveiki!");

            List<Animal> animals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("Pasirinkite ka ivesite: ");
                Console.WriteLine("1-kate");
                Console.WriteLine("2- suo");
                Console.WriteLine("3-baigti");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Cat cat = GetCat();
                        animals.Add(cat);
                        break;
                    case "2":
                        Dog dog = GetDog();
                        animals.Add(dog);
                        break;
                }

                if (userChoice == "3")
                {
                    break;
                }
            }

            PrintAnimals(animals);
        }

        private static Cat GetCat()
        {
            Console.WriteLine("Iveskite kates varda: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite kates amziu: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite kates veisle: ");
            string breed = Console.ReadLine();

            Console.WriteLine("Iveskite kates spalva: ");
            string color = Console.ReadLine();

            Console.WriteLine("Ar kate megsta piena t/n: ");
            string answer = Console.ReadLine();

            bool likesMilk = answer.ToLower() == "t";

            return new Cat(name, age, breed, color, likesMilk);
        }

        private static Dog GetDog()
        {
            Console.WriteLine("Iveskite suns varda: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite suns amziu: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite suns veisle: ");
            string breed = Console.ReadLine();

            Console.WriteLine("Iveskite suns spalva: ");
            string color = Console.ReadLine();

            Console.WriteLine("Ar suo yra policijos suo t/n: ");
            string answer = Console.ReadLine();

            bool isPoliceDog = answer.ToLower() == "t";

            return new Dog(name, age, breed, color, isPoliceDog);
        }

        private static void PrintAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetAnimalInfo()}");
                Console.WriteLine($"Gyvunas sako: {animal.MakeSound()}");

                if (animal is Dog)
                {
                    Console.WriteLine($"Tai yra suo.");
                }
                else if (animal is Cat)
                {
                    Console.WriteLine($"Tai yra kate.");
                }

                Console.WriteLine();
            }
        }
    }
}
