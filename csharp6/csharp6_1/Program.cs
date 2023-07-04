namespace csharp6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naudojant if sąlygas:
            //Užduotis 1: Patikrinti, ar skaičius yra didesnis nei 50.

            Random random = new Random();
            int number = random.Next(1, 101);

            Console.WriteLine(number);
            Console.WriteLine(number > 50);
        }
    }
}