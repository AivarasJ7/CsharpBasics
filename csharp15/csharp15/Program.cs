namespace csharp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 1: Sukurkite dvimatį masyvą su atsitiktiniais skaičiais ir parašykite programą, 
            // kuri apskaičiuotų kiekvieno stulpelio sumą.

            int rows = 5;
            int cols = 4;

            Random random = new Random();

            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            int[] columnSums = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }
                columnSums[j] = sum;
            }

            Console.WriteLine("Dvimatis masyvas:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Stulpelio sumos:");
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Stulpelis {j + 1}: {columnSums[j]}");
            }
        }
    }
}