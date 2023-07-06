namespace pair_programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Parašyti for, kuris išvestų kas antrą skaičių pradedant 0
            //ir baigiant 15.Kiekvieną skaičių išvesti toje pačioje eilutėje,
            //po kiekvieno skaičiaus dedant tarpą.

            for (int i = 0; i <= 15; i += 2)
            {
                Console.Write($"{i} ");
            }
        }
    }
}