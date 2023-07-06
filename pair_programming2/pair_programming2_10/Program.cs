namespace pair_programming2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.(Ats.675 )

            int result = 0;

            for (int i = 30; i < 60; i++)
            {
                if(i % 2 != 0)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
        }
    }
}