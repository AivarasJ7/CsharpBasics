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
        }
    }
}