namespace loop_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //susipazinimui
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello world");
            }

            Console.WriteLine("Ciklas baigiasi");

            // isvesti skaicius nuo 1 iki 10

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(i);
            }

            //isvesti visus lyginius skaicius nuo 2 iki 20
            Console.WriteLine("Lyginiu skaiciu paieska, 1 budas");
            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Lyginiu skaiciu paieska 2 budas");

            for (int i = 2; i <= 20; i+= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}