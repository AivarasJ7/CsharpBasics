using System;

namespace csharp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Sukurkite List<string> sąrašą su 5 vardais ir parašykite programą, kuri rikiuoja sąrašą pagal abėcėlę.

            List<string> names = new List<string>()
            {
                "Jonas",
                "Petras",
                "Arunas",
                "Martynas",
                "Juozas"
            };

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //2. Parašykite programą, kuri leidžia vartotojui įvesti n sveikųjų skaičių į List<int> sąrašą, 
            // o tada randa ir atspausdina didžiausią ir mažiausią skaičių.

            List<int> numbers = new List<int>();

            Console.WriteLine("Iveskite elementu skaiciu: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Iveskite skaiciu #{i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            if (numbers.Count > 0)
            {
                int largest = numbers[0];
                int smallest = numbers[0];

                foreach (int number in numbers)
                {
                    if (number > largest)
                        largest = number;

                    if (number < smallest)
                        smallest = number;
                }

                Console.WriteLine($"Didziausias skaicius: {largest}");
                Console.WriteLine($"Maziausias skaicius: {smallest}");
            }

            else
            {
                Console.WriteLine("Neteisingai pasirinktas elementu skaicius.");
            }
        }
    }
}