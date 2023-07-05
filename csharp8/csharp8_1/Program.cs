namespace csharp8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Liepkite vartotojui įvesti du skaičius. Raskite kuris skaičius yra didesnis. Su viena if sąlyga (bei visomis jos dalimis) atlikite šiuos patikrinimus:
            //1.1.ar pirmas skaičius didesnis už antrą skaičių;
            //1.2.ar antras skaičius didesnis už pirmą;
            //1.3.jei niekas neatitinka -tuomet skaičiai lygūs.

            Console.WriteLine("Iveskite skaiciu: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Pirmas skaičius '{num1}' yra didesnis už antrąjį '{num2}'.");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Antras skaičius '{num2}' yra didesnis už pirmąjį '{num1}'.");
            }
            else
            {
                Console.WriteLine("Skaičiai yra lygūs.");
            }
        }
    }
}