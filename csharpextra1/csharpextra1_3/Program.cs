namespace csharpextra1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Parašykite programą, kuri naudodama funkciją randa visų skaičių nuo 1 iki vartotojo įvesto skaičiaus suma bei sandaugą.
            // Programa turi išvesti rezultatus ekrane. Pvz.:
            // Suma: 1 + 2 + 3 + 4 + 5 = 15
            // Sandauga: 1 * 2 * 3 * 4 * 5 = 120

            Console.Write("Iveskite skaiciu: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int multiply = 1;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
                multiply *= i;
            }

            Console.WriteLine($"Suma: {GetSequenceString(1, number, "+")} = {sum}");
            Console.WriteLine($"Sandauga: {GetSequenceString(1, number, "*")} = {multiply}");

            Console.ReadLine();
        }

        static string GetSequenceString(int startingNum, int lastNum, string operatorSymbol)
        {
            string result = "";
            for (int i = startingNum; i <= lastNum; i++)
            {
                result += i;
                if (i < lastNum)
                    result += " " + operatorSymbol + " ";
            }

            return result;
        }
    }
}