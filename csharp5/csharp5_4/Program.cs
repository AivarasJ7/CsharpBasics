namespace csharp5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Visose užduotyse turi išspausdinti true arba false ekrane. Pvz.
            //"Ar duotas skaičius yra lyginis ir didesnis nei 10? atsakymas: true"
            //Užduotis 4: Patikrinkite, ar vartotojas turi teisę gauti nuolaidą, jei nuolaida galioja studentams arba senjorams.
            // studentas (18, 25] senjoras > 65

            Console.WriteLine("Iveskite savo amziu: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(age > 18 && age <= 25 || age > 65);
        }
    }
}