namespace pair_programming4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10.
            //Jame apsirašyti if sąlygą, kuri patikrintų ar dabartinis skaičius yra lyginis,
            //jei taip tai šį skaičių išvesti.

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}