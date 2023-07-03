namespace if_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("patekau i if vidu");
            }

            int age = 18;

            if (age >= 20)
            {
                Console.WriteLine("Sveiki atvyke i svetaine");
            }

            // patikrinti ar skaiciu yra lyginis
            // naudojame modaline dalyba is 2 ir jei rezultatas palyginus su 0 yra true 
            // tuomet skaicius yra lyginis

            int number1 = 10;

            if (number1 % 2 == 0)
            {
                Console.WriteLine($"Skaicius {number1} yra lyginis");
            }

            //patikrinti ar skaicius yra nelyginis
            number1 = 21;
            bool isOddNumber = number1 % 2 != 0;
            if (isOddNumber) //!true - false, !false - true
            {
                Console.WriteLine($"Skaicius {number1} yra nelyginis");
            }
        }
    }
}