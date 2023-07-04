namespace csharp7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Liepkite vartotojui įvesti įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            //3.1. ar temperatūra < 0 - išvesti “žiauriai šalta”;
            //3.2. ar temperatūra < 10 - išvesti “labai šalta”;
            //3.3. ar temperatūra < 20 - išvesti “šalta”;
            //3.4. ar temperatūra < 30 - išvesti “normali temperatūra”;
            //3.5. ar temperatūra < 40 - išvesti “karšta”;
            //3.6. ar temperatūra > 40 - išvesti “visiškai degina”;

            Console.WriteLine("Iveskite šios dienos oro temperatūrą: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine($"{temp}  žiauriai šalta");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine($"{temp}  labai šalta");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine($"{temp}  šalta");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine($"{temp}  normali temperatūra");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine($"{temp}  karšta");
            }
            else if (temp >= 40)
            {
                Console.WriteLine($"{temp}  visiškai degina");
            }
        }
    }
}