using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5.Išveskite pasirinkto skaičiaus daugybos lentelę. Pvz.:
                5 * 0 = 0
                5 * 1 = 5
                …
                5 * 10 = 50
            */

            int num1 = 4;
            int table = 10;

            for (int i = 1; i <= table; i++)
            {
                int result = num1 * i;
                Console.WriteLine($"{num1} * {i} = {result}");
            }


        }
    }
}