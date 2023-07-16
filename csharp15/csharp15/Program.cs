namespace csharp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 1: Sukurkite dvimatį masyvą su atsitiktiniais skaičiais ir parašykite programą, 
            // kuri apskaičiuotų kiekvieno stulpelio sumą.

            Random random = new Random();

            int[,] array = new int[5, 4];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Dvimatis masyvas:");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col] + "\t");
                }
                Console.WriteLine();
            }

            for (int col = 0; col < array.GetLength(1); col++)
            {
                int columnSum = 0;
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    columnSum += array[row, col];
                }

                Console.WriteLine($"Stulpelis {col + 1}: {columnSum}");
            }
        }
    }
}