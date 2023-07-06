namespace pair_programming2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. Raskite visų lyginių skaičių nuo 20 iki 50 sumą. (Ats.510 )

            int result = 0;

            for (int i = 20; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
                
            }

            Console.WriteLine(result);
        }
    }
}