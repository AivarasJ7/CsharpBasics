namespace csharp5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Visose užduotyse turi išspausdinti true arba false ekrane.
            //Pvz. "Ar duotas skaičius yra lyginis ir didesnis nei 10? atsakymas: true"
            //Užduotis 3: Patikrinkite, ar vartotojo amžius yra tarp 18 ir 65 metų imtinai.
            // [18, 65]

            Console.WriteLine("Iveskite savo amziu: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(age >= 18 && age <= 65);
        }
    }
}