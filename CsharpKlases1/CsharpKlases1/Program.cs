namespace CsharpKlases1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Sukurkite klasę studento informacijai saugoti.
            // Savybės, kurias turi studentas tai Vardas, Pavardė, Amžius, Lytis.
            // Sugalvokite dar dvi sąvybes.
            // Studento klasė turi metodą Prisistatyti.Iškvietus metodą, ekrane išspausdinamas tekstas: "Aš Jonas Jonaitis. Esu vyras. Man 28."
            // Savybės ir metodai anglų kalba.

            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Uzregistruoti Studenta:");
                Student student = new Student();

                Console.Write("Iveskite studento varda:");
                student.Name= Console.ReadLine();

                Console.Write("Iveskite studento pavarde:");
                student.Surname = Console.ReadLine();

                Console.Write("Iveskite studento amziu:");
                student.Age = int.Parse(Console.ReadLine());

                Console.Write("Iveskite studento lyti:");
                student.Gender = Console.ReadLine();

                Console.Write("Iveskite studento ugi (cm):");
                student.Height = int.Parse(Console.ReadLine());

                Console.Write("Iveskite studento svori (kg):");
                student.Weight = int.Parse(Console.ReadLine());

                students.Add(student);

                Console.WriteLine("Ar norite testi t/n?");
                string choice = Console.ReadLine();

                if (choice != "t")
                {
                    break;
                }
            }

            foreach (Student student in students)
            {
                student.MakeAGreeting();
            }
        }
    }
}