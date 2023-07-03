namespace chsharp5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Visose užduotyse turi išspausdinti true arba false ekrane. Pvz.
             "Ar duotas skaičius yra lyginis ir didesnis nei 10? atsakymas: true"
              Užduotis 1: Patikrinkite, ar duotas skaičius yra lyginis ir didesnis nei 10.
             */

            Random random = new Random();
            int number = random.Next(0, 100);

            Console.WriteLine(number);
            Console.WriteLine(number % 2 == 0 && number > 10);
        }
    }
}