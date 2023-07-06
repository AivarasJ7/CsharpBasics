namespace loop_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //amzino ciklo pavizdys
            //Thread.Sleep(1000);
            // Console.WriteLine("labas");

            //isspausdinti skaiciu nuo 1 iki 10 (kaip for while)
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //ivedinejimas kol vartotojas ives teigiam skaiciu
            Console.WriteLine("Iveskite teigiama skaiciu: ");
            int number = int.Parse(Console.ReadLine());

            while (number <= 1)
            {
                Console.WriteLine("Ivedete neigiama arba 0, " +
                    "bandykite dar karta: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Jus ivedete teigiama skaiciu {number}");

            // rasti pirmaji skaiciu kurio kvadratas yra didesnis
            // uz 1000

            int answer = 1;
            while (answer * answer <= 1000) //PathPow irgi galima
            { 
                answer++;
            }

            Console.WriteLine($"Pirmasis skaiciu kurio kvadratas " +
                $"didesnis uz 1000 yra {answer}");
        }
    }
}