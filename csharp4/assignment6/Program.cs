namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.:
              Įvestų skaičių 4, 5, 8 vidurkis: 5,6
             */
            Console.Write("Įveskite skaičių: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Įveskite skaičių: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Įveskite skaičių: ");
            int num3 = int.Parse(Console.ReadLine());

            double numAverage = (num1 + num2 + num3) / 3.0;

            Console.WriteLine($"Įvestų skaičių {num1}, {num2}, {num3} vidurkis: {numAverage}");
        }
    }
}