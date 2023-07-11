using System.Xml.Linq;

namespace pair_programming_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Užduotis: Sukurti string tipo masyvą, pakeisti vieną elementą ir atspausdinti masyvą.
            //Aprašymas: Sukurkite string tipo masyvą su penkiais elementais. Pakeiskite antrojo elemento reikšmę nauja reikšme. 
            //Iteruokite per masyvą ir atspausdinkite kiekvieną elementą.

            string[] words = {"aa", "bb", "cc", "dd", "ee" };

            words[1] = "pakeista";

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}