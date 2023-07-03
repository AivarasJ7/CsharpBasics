namespace csharp5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Visose užduotyse turi išspausdinti true arba false ekrane. 
            //Pvz. "Ar duotas skaičius yra lyginis ir didesnis nei 10? atsakymas: true"
            //Užduotis 2: Nustatykite, ar bent vienas iš trijų skaičių yra teigiamas.

            Console.WriteLine("Iveskite pirma skaiciu: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite trecia skaiciu: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                num1 > 0 ||
                num2 > 0 ||
                num3 > 0);
        }
    }
}