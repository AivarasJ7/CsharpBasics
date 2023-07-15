namespace csharp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 1: Sukurkite dvimatį masyvą, kuriame bus saugomi studentų pažymiai kiekvienam dalykui. 
            // Apskaičiuokite visų pažymių sumą ir vidurkį.

            int[,] studentGrades = new int[,]
            {
                {10, 5, 8, 7, 6 },
                {9, 7, 4, 3, 7},
                {5, 8, 7, 4, 10}
            };

            int sum = 0;

            for (int row = 0; row < studentGrades.GetLength(0); row++)
            {
                for (int col = 0; col < studentGrades.GetLength(1); col++)
                {
                    sum += studentGrades[row, col];
                }
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {(double)sum / studentGrades.Length}");
        }
    }
}