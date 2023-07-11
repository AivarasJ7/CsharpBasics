namespace csharp10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE ciklo arba do -while naudojimas.
            //2. Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0,
            //taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0. Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.

            Console.WriteLine("Iveskite neigiama skaiciu: ");
            int number = int.Parse(Console.ReadLine());

            while (number <= 0)
            {
                Console.Write($"{number} ");
                number++;
            }
        }
    }
}