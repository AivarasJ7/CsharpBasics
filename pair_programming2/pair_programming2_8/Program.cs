namespace pair_programming2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8. Raskite visų skaičių nuo 1 iki 100 sumą. (Ats.4950 )

            int result = 0;

            for (int i = 1; i < 100; i++)
            {
                result = result + i;
            }

            Console.WriteLine(result);
        }
    }
}