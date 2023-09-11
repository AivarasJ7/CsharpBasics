namespace classes_inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, atvyke!");

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

            Console.WriteLine("Iveskite kates veisle: ");
            string breed = Console.ReadLine();

            return new Cat(name, breed);
        }

        private static Dog GetDog()
        {
            Console.WriteLine("Iveskite suns varda: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite suns veisle: ");
            string breed = Console.ReadLine();

            Console.WriteLine("Ar suo yra policijos suo t/n: ");
            string answer = Console.ReadLine();

            bool isPoliceDog = answer.ToLower() == "t";

            return new Dog(name,breed,isPoliceDog);
        }

        private static void PrintAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetAnimalInfo()}");
                if (animal is Cat cat)
                {
                    Console.WriteLine($"{cat.GetWhatCatSays()}");
                }

                if(animal is Dog dog)
                {
                    Console.WriteLine($"{dog.GetWhatDogSays()}");

                    if (dog.IsPoliceDog)
                    {
                        Console.WriteLine($"And this is a police dog.");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}