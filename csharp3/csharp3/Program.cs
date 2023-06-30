namespace csharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį, kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. Pvz.:
                4 + 5 = 9
                4 - 5 = -1
                …
            */

            int num1 = 4;
            int num2 = 5;

            int sum = num1 + num2;
            int difference = num1 - num2;
            int multiplication = num1 * num2;
            double division = (double)num1 / num2;

            Console.WriteLine("Suma: {0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("Skirtumas: {0} - {1} = {2}", num1, num2, difference);
            Console.WriteLine("Sandauga: {0} * {1} = {2}", num1, num2, multiplication);
            Console.WriteLine("Dalyba: {0} / {1} = {2}", num1, num2, division);
        }
    }
}