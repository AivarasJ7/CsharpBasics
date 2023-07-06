namespace pair_programming3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Parašyti for, kuris išvestų kas trečią skaičių,
            //pradedant 1 ir baigiant 20.Kiekvieną skaičių išvesti toje pačioje eilutėje
            //tačiau apskliaudžiant laužtiniais skliaustais.Pvz.: [1][4][7]...

            for (int i = 1; i <= 20; i += 3)
            {
                Console.Write($"[{i}]");
            }
        }
    }
}