namespace csharp23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Parašykite metodą, kuris pasisveikintų su vartotoju.
            // Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
            // Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda formatuotai(jūsų pasirinktu formatu).

            Console.Write("Iveskite savo varda:");
            string name = Console.ReadLine();

            Console.Write("Iveskite savo amziu:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Iveskite savo hobio pavadinima:");
            string hobby = Console.ReadLine();

            GreetUser(name, age, hobby);
        }

        private static void GreetUser(string name, int age, string hobby) 
        {
            Console.WriteLine($"Sveiki {name} jums yra {age} metu ir jusu hobis yra {hobby}");
        }
    }
}