namespace csharp5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Visose užduotyse turi išspausdinti true arba false ekrane. Pvz.
            //"Ar duotas skaičius yra lyginis ir didesnis nei 10? atsakymas: true"
            //Užduotis 5: Nustatykite, ar duotas skaičius yra neigiamas 
            //ir ar jo liekana, dalijant iš 3, yra lygi 2.

            Random random = new Random();
            int number = random.Next(-50, 51);

            Console.WriteLine(number);

            Console.WriteLine(
                number < 0 &&
                (number % 3) % 2 == 0
            );
        }
    }
}