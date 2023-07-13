namespace two_dimension_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dvimaciu masyvu deklaravimas
            int[,] array1 = new int[3, 4]; // eilutes stulpeliai
            string[,] array2 = new string[2, 2];

            // inicializavimas su duomenimisint
            int[,] studentGrades = new int[,] //3, 5
            {
                {10, 5, 8, 7, 6 },
                {9, 7, 4, 3, 7},
                {5, 8, 7, 4, 10}
            };

            // elementu pasiekamumas
            Console.WriteLine(studentGrades[1, 0]);
            Console.WriteLine(studentGrades[1, 1]);
            Console.WriteLine(studentGrades[1, 2]);
            Console.WriteLine(studentGrades[1, 3]);
            Console.WriteLine(studentGrades[1, 4]);

            //iteracija
            // .getLength(1); 0 reiskia eiluciu skaiciu o 1 stulpeliu skaiciu
            Console.WriteLine("iteracija per stulpelius");
            for (int col = 0; col < studentGrades.GetLength(1); col++)
            {
                Console.WriteLine(studentGrades[1, col]);
            }

            Console.WriteLine("Iteracija per eilutes");
            for (int row = 0; row < studentGrades.GetLength(0); row++)
            {
                Console.WriteLine(studentGrades[row, 0]);
            }

            Console.WriteLine("Spausdinam visus: ");
            for (int row = 0; row < studentGrades.GetLength(0); row++)
            {
                for (int col = 0; col < studentGrades.GetLength(1); col++)
                {
                    Console.Write($"{studentGrades[row, col]} ");
                }

                Console.WriteLine();
            }

            //game board

            int[,] gameBoard =
            {
                {0, 2, 0, 2, 0, 2, 0, 2 },
                {2, 0, 2, 0, 2, 0, 2, 0 },
                {0, 2, 0, 2, 0, 2, 0, 2 },
                {1, 0, 1, 0, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 1 },
                {3, 0, 3, 0, 3, 0, 3, 0 },
                {0, 3, 0, 3, 0, 3, 0, 3 },
                {3, 0, 3, 0, 3, 0, 3, 0 },

            };

            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    if (gameBoard[row, col] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("   ");
                    }
                    else if (gameBoard[row, col] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" O ");
                    }
                    else if (gameBoard[row, col] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" O ");
                    }
                    else 
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("   ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}