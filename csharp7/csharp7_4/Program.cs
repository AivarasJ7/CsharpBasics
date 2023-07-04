using System.Reflection.Emit;

namespace csharp7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Liepkite vartotojui įvesti gautą pažymį, atlikite šiuos veiksmus:
            //4.1.jei 10 - išveskite “Puikiai”;
            //4.2.jei 8 - 9 - išveskite “Labai gerai”;
            //4.3.jei 5 - 7 - išveskite “Patenkinamai”;
            //4.4.jei 3 - 4 - išveskite “Prastai”;
            //4.5.jei 1 - 2 - išveskite “Labai blogai”;

            Console.WriteLine("Iveskite gautą pažymį (1-10 imtinai): ");
            int score = int.Parse(Console.ReadLine());

            if (score == 10)
            {
                Console.WriteLine($"{score} - Puikiai");
            }
            else if (score == 8 || score == 9)
            {
                Console.WriteLine($"{score} - Labai gerai");
            }
            else if (score == 5 || score == 6 || score == 7)
            {
                Console.WriteLine($"{score} - Patenkinamai");
            }
            else if (score == 3 || score == 4)
            {
                Console.WriteLine($"{score} - Prastai");
            }
            else if (score == 1 || score == 2)
            {
                Console.WriteLine($"{score} - Labai blogai");
            }
        }
    }
}