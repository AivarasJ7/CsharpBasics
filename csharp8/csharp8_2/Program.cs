namespace csharp8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Liepkite vartotojui įvesti vieną norimą skaičių. Su viena if sąlyga (ir visomis jos dalimis), patikrinkite šiuos dalykus:
            //2.1.ar skaičius neigiamas;
            //2.2.ar skaičius teigiamas;
            //2.3.ar skaičius lygus 0.

            Console.WriteLine("Iveskite skaiciu: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine($"Skaicius '{number}' yra neigiamas.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"Skaicius '{number}' yra teigiamas.");
            }
            else
            {
                Console.WriteLine("Skaičius yra lygus 0");
            }
        }
    }
}