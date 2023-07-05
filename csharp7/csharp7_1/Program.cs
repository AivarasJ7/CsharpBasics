namespace csharp7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
            //1.1. ar pirmas skaičius didesnis už antrą;
            //1.2. ar antras skaičius didesnis už trečią;
            //1.3. ar trečias skaičius skaičius didesnis už pirmą;
            //1.4. ar pirmi du skaičiai lygūs;

            Console.WriteLine("Įveskite tris skaičius:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrą.");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Antras skaičius yra didesnis už trečią.");
            }
            else if (num3 > num1)
            {
                Console.WriteLine("Trečias skaičius yra didesnis už pirmą.");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Pirmas ir antras skaičiai yra lygūs.");
            }
        }
    }
}