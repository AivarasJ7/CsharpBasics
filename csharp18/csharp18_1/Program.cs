using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Sukurkite List<bool> sąrašą su 20 atsitiktiniais teigiamais/negative reikšmėmis. 
            // Parašykite programą, kuri suskaičiuoja, kiek teigiamų ir neigiamų reikšmių yra sąraše.

            List<bool> boolList = new List<bool>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                bool randomBoolValue = random.Next(2) == 0;
                boolList.Add(randomBoolValue);
            }

            int positiveBoolCount = 0;
            int negativeBoolCount = 0;

            foreach (bool value in boolList)
            {
                Console.WriteLine($"{value} ");
                if (value == true)
                {
                    positiveBoolCount++;
                }
                if (value == false)
                {
                    negativeBoolCount++;
                }
            }
            Console.WriteLine($"Sarase yra teigiamu reiksmiu: {positiveBoolCount}, o neigiamu yra {negativeBoolCount}");
        }
    }
}