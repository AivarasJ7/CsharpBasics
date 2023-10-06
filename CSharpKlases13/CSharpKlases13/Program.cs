namespace CSharpKlases13
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Mokslininkų klasės: Sukurkite pagrindinę Scientist klasę su savybėmis Name ir FieldOfStudy ir metodu PrintScientistInfo(),
            // kuris išveda visą informaciją apie mokslininką.
            // Tada sukurkite paveldėtą klasę Physicist su papildoma savybe Specialization ir papildomu metodu PrintPhysicistInfo(),
            // kuris išveda informaciją apie fiziką. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė, o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            Console.WriteLine("Sveiki!");

            List<Scientist> scientists = new List<Scientist>();

            while (true)
            {
                Console.WriteLine("Pasirinkite ka darysite: ");
                Console.WriteLine("1 - Prideti nauja mokslininka");
                Console.WriteLine("2 - Prideti nauja Fizika");
                Console.WriteLine("3 - Baigti");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Scientist scientist = GetScientist();
                        scientists.Add(scientist);
                        break;
                    case "2":
                        Physicist physicist = GetPhysicist();
                        scientists.Add(physicist);
                        break;
                }

                if (userChoice == "3")
                {
                    break;
                }
            }

            PrintScientists(scientists);
        }

        private static Scientist GetScientist()
        {
            Console.WriteLine("Iveskite mokslininko varda: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite studiju sryti: ");
            string fieldOfStudy = Console.ReadLine();

            return new Scientist(name, fieldOfStudy);
        }

        private static Physicist GetPhysicist()
        {
            Console.WriteLine("Iveskite fiziko varda: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite studiju sryti: ");
            string fieldOfStudy = Console.ReadLine();

            Console.WriteLine("Iveskite specilizacija: ");
            string specialization = Console.ReadLine();

            return new Physicist(name, fieldOfStudy, specialization);
        }

        private static void PrintScientists(List<Scientist> scientists)
        {
            foreach (Scientist scientist in scientists)
            {
                if (scientist is Physicist physicist)
                {
                    physicist.PrintPhysicistInfo();
                }
                else
                {
                    scientist.PrintScientistInfo();
                }
            }
        }
    }
}