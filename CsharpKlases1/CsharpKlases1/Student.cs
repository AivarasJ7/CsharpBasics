namespace CsharpKlases1
{
    public class Student
    {
        // Sukurkite klasę studento informacijai saugoti.
        // Savybės, kurias turi studentas tai Vardas, Pavardė, Amžius, Lytis.
        // Sugalvokite dar dvi sąvybes.
        // Studento klasė turi metodą Prisistatyti.Iškvietus metodą, ekrane išspausdinamas tekstas: "Aš Jonas Jonaitis. Esu vyras. Man 28."
        // Savybės ir metodai anglų kalba.

        //savybes - properties (public)

        public string Name;
        public string Surname;
        public int Age;
        public string Gender;
        public int Height;
        public int Weight;

        //metodai - (public)
        public void MakeAGreeting()
        {
            Console.WriteLine();
            Console.WriteLine($"As {Name} {Surname}. Esu {Gender}. Man yra {Age} metai-(u), " +
                $"mano ugis yra {Height}cm, o svoris {Weight}kg.");
        }

    }
}
