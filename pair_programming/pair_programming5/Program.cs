namespace pair_programming5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Liepkite vartotojui įvesti rėžių pradžią ir pabaigą.
            //Patikrinkite, kad tai būtų validu(pradžia turi būti mažesnė nei pabaiga).
            //Jei rėžiai tinkami, tuomet vykdyti for, kuris atskirose eilutėse išvestų kiekvieną skaičių
            //iš tų rėžių, bei atskiriant tarpu - tų skaičių kvadratus.

            int start;
            int end;

            do
            {
                Console.WriteLine("Iveskite reziu pradzia:");
                start = int.Parse(Console.ReadLine());

                Console.WriteLine("Iveskite reziu pabaiga:");
                end = int.Parse(Console.ReadLine());

            } while (start > end);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i} {i * i}");
            }
        }
    }
}