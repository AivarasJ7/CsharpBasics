namespace csharp13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Susikurkite studentų pažymių masyvą. Raskite:

            int[] studentGrades = { 9, 7, 1, 6, 5, 3, 9, 10, 9, 10, 6, 8, 5, 4, 8, 2, 7, 10, 10, 8 };

            // 2.1.geriausią pažymį;

            Console.Write("Geriausias pazimys: ");
            Console.WriteLine(studentGrades.Max());

            // 2.2.kiek mokinių yra gavę dešimtukus;

            int perfectGradeCount = 0;

            foreach (int studentGrade in studentGrades)
            {
                if (studentGrade == 10)
                {
                    perfectGradeCount++;
                }
            }

            Console.WriteLine($"Mokiniu kurie yra gave desimtukus yra {perfectGradeCount}");

            // 2.3.kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);

            int negativeGradeCount = 0;

            foreach (int studentGrade in studentGrades)
            {
                if (studentGrade < 4)
                {
                    negativeGradeCount++;
                }
            }

            Console.WriteLine($"Mokiniu kurie yra gave neigiama pazymi(zemiau nei 4) yra {negativeGradeCount}");

            // 2.4.pažymių vidurkį;

            Console.WriteLine($"Visu pazymiu vidurkis: {studentGrades.Average()}");
        }
    }
}