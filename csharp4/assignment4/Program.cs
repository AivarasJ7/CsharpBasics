using System.Xml.Linq;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Liepkite vartotojui įvesti tris skaičius. Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį,
              nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:
              5 + 3 + 8 = 16
              5 - 3 - 8 = -6
             */

            Console.Write("Iveskite skaičių: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Iveskite skaičių: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Iveskite skaičių: ");
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            int difference = num1 - num2 - num3;
            int multiplication = num1 * num2 * num3;
            decimal division = (decimal)num1 / num2 / num3;

            Console.WriteLine("Suma: {0} + {1} + {2} = {3}", num1, num2, num3, sum);
            Console.WriteLine("Skirtumas: {0} - {1} - {2} = {3}", num1, num2, num3, difference);
            Console.WriteLine("Sandauga: {0} * {1} * {2} = {3}", num1, num2, num3, multiplication);
            Console.WriteLine("Dalyba: {0} / {1} / {2} = {3}", num1, num2, num3, division);
        }
    }
}