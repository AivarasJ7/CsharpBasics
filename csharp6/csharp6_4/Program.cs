using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naudojant if sąlygas:
            //Užduotis 4: Patikrinti, ar vartotojo amžius yra tarp 13 ir 19 metų, o ugis yra didesnis nei 160 cm.
            // (14, 19) && height > 160 )

            Console.WriteLine("Iveskite savo amziu: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite savo ugi (cm): ");
            int height = int.Parse(Console.ReadLine());

            if (age >= 14 && age < 19 && height > 160)
            {
                Console.WriteLine($"Jusu amzius {age} yra tarp 13 ir 19 metų, o ugis {height} yra didesnis nei 160 cm."); //++
            }
            else if (age >= 14 && age < 19 && height < 160) 
            {
                Console.WriteLine($"Jusu amzius {age} yra tarp 13 ir 19 metų, bet ugis {height} nera didesnis nei 160 cm."); //+-
            }
            else if (age <= 13 || age >= 19 && height < 160)
            {
                Console.WriteLine($"Jusu amzius {age} nera tarp 13 ir 19 metų, ir ugis {height} nera didesnis nei 160 cm."); //--
            }
            else if (age <= 13 || age >= 19 && height > 160)
            {
                Console.WriteLine($"Jusu amzius {age} nera tarp 13 ir 19 metų, bet ugis {height} yra didesnis nei 160 cm."); //--
            }
        }
    }
}