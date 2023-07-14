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
            int count = 0;

            for (int row = 0; row < studentGrades.GetLength(0); row++) // Nezinau ar gerai cia tie (row, col) bet labai man aiskiai matosi kas kaip vaiksto. Siaip pamenu sakei raideles turi buti i ir j? berods.
            {
                for (int col = 0; col < studentGrades.GetLength(1); col++)
                {
                    sum += studentGrades[row, col];
                    count++;
                }
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {(double)sum / count}");
        }
    }
}