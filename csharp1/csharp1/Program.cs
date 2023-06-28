using System.Xml.Linq;

namespace csharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vienas assignment -vienas solution, vienas merge request.
            //Susikurkite C# programą, kurioje aprašykite kintamuosius kode. Pagal reikalavimus (Code convention).
            //Vardas;
            //Pavardė;
            //Amžius;
            //Ūgis;
            //Svoris;
            //Aukštoji mokykla;
            //Akademinės grupės kodas;
            //Kursas;
            //Studijų programos pavadinimas;
            //Atsiskaitytų kreditų skaičius;

            string firstName = "Aivaras";
            string lastName = "Jastrumskis";
            int age = 26;
            int height = 193;
            double weight = 82.1;
            string highSchool = "Sodu vidurine mokykla";
            int academicGroupCode = 326;
            int course = 1;
            string studyProgram = "Programming";
            double gpa = 4.9;

            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} Cm");
            Console.WriteLine($"Weight: {weight} Kg");
            Console.WriteLine($"High school: {highSchool}");
            Console.WriteLine($"Academic group code: {academicGroupCode}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Study program: {studyProgram}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }
}