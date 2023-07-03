using System;

namespace if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // surasykime simtabaleje sistemoje israiska zodziais
            //100 - puikiai
            //[90, 100) - labai gerai
            //[80, 90) - gerai
            //[70, 80) - neblogai
            //[0, 70) - blogai

            Random random = new Random();
            int score = random.Next(0, 101);

            if (score == 100)
            {
                Console.WriteLine($"{score} - puikiai!");
            }
            else if (score >= 90 && score < 100)
            {
                Console.WriteLine($"{score} - labai gerai");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine($"{score} - gerai");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine($"{score} - neblogai");
            }
            else if (score >= 0 && score < 70)
            {
                Console.WriteLine($"{score} - blogai");
            }
        }
    }
}