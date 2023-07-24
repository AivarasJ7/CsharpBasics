namespace csharp24
{
    public class Project
    {
        public static void Main(string[] args)
        {
            // Leiskite vartotojui įvesti du sveikuosius skaičius į programą.
            // Sukurkite ir panaudokite šiuos metodus:
            // Suma;
            // Skirtumas;
            // Sandauga;
            // Dalmuo;

            // Metodams parašykite testus.

            // Rezultatas paveikslėlyje.

            Console.WriteLine("Iveskite sveikaji skaiciu: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite dar viena sveikaji skaiciu: ");
            int number2 = int.Parse(Console.ReadLine());

            int addResult = Add(number1, number2);
            int differenceResult = Difference(number1, number2);
            int multiplyResult = Multiply(number1, number2);
            double divisionResult = Division(number1, number2);

            Console.WriteLine($"{number1} + {number2} = {addResult}");
            Console.WriteLine($"{number1} - {number2} = {differenceResult}");
            Console.WriteLine($"{number1} * {number2} = {multiplyResult}");
            Console.WriteLine($"{number1} / {number2} = {divisionResult}");
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Difference(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Division(int number1, int number2)
        {
            return (double)number1 / number2;
        }
    }
}