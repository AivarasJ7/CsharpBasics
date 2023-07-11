namespace csharp10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.Sukurkite string tipo kintamąjį.Prie jo vis pridėkite vartotojo įrašomus skirtingus žodžius. 
            // Tačiau jei vartotojas įrašytų “exit” -baigti ciklą.Baigus vykdyti ciklą turi būti išvestas string kintamasis prie kurio vis buvo pridedami skirtingi žodžiai. 
            // (pridėtas paveiksliukas 4.jpg)

            string result = string.Empty;
            string input;

            while (true)
            {
                Console.Write("Iveskite zodi arba exit: ");
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                result += input + " ";
            }

            Console.WriteLine($"Rezultatas: {result} ");
        }
    }
}