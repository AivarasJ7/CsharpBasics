using System;

namespace csharp17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą. 
            // Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę.

            List<int> studentGrades = new List<int>();

            Console.Write("Iveskite studentu skaiciu: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Iveskite {i + 1}-ojo studento pazymi: ");
                int grade = int.Parse(Console.ReadLine());

                studentGrades.Add(grade);
            }

            // Raskite: 2.1.didžiausią pažymį;

            Console.WriteLine($"Didziausias pazimys: {studentGrades.Max()}");

            // 2.2.mažiausią pažymį;

            Console.WriteLine($"Maziausias pazimys: {studentGrades.Min()}");

            // 2.3.vidurkį;

            Console.WriteLine($"Pazymiu vidurkis: {studentGrades.Average()}");

            // 2.4.išveskite atsitiktinį skaičių iš šio sąrašo.

            Random random = new Random();
            Console.WriteLine($"Atsitiktinis skaicius is saraso: {studentGrades[random.Next(studentGrades.Count)]}");
        }
    }
}