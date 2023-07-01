namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5.Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. Pvz.:
                2 * 1 = 2
                …
                2 * 5 = 10
             * 
             * 
             */
            int multiplicationTableSize = 5;

            Console.Write("Įveskite bet kokį sveikąjį skaičių: ");
            int num1 = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= multiplicationTableSize; i++)
            {
                int result = num1 * i;
                Console.WriteLine($"{num1} * {i} = {result}");
            }
        }
    }
}