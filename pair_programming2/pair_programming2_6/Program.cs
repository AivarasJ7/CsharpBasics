namespace pair_programming2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. 
            // Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga). 
            // Jei rėžiai tinkami, tuomet vykdyti for, kuris iš duotų skaičių išvestų visus nelyginius skaičius arba tuos, kurie dalinasi iš 8.
            int start;
            int end;

            do
            {
                Console.WriteLine("Iveskite reziu pradzia: ");
                start = int.Parse(Console.ReadLine());

                Console.WriteLine("Iveskite reziu pabaiga: ");
                end = int.Parse(Console.ReadLine());

            } while (start > end);

            for (int i = start; i < end; i++)
            {
                if (i % 2 != 0 || i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}