using System;

namespace csharp23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paprastutė užduotis pirmiesiems įgudžiams su metodais:
            // 1.Aprašykite ir iškvieskite metodą, kuris išvestų bet kokį jūsų pasirinktą tekstą.

            PrintText("Sveiki");
        }

        private static void PrintText (string text) 
        {
            Console.WriteLine(text);
        }
    }
}