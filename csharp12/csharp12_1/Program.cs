using static System.Reflection.Metadata.BlobBuilder;

namespace csharp12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Susikurti šiuos masyvus su duomenimis:
            // 1.1.skirtą studentų pažymiams saugoti;

            int[] studentGrades = { 9, 7, 8, 6, 5, 6, 9, 10, 9, 10, 6, 8, 5, 4, 8, 8, 7, 10, 10, 8 };

            // 1.2.skirtą mašinų markėms saugoti;

            string[] carBrands = { "Ford", "BMW", "Audi", "Opel", "Dodge", "Toyota" };

            // 1.3.savo norimą.

            string[] cardSuits = { "spades", "clubs", "hearts", "diamonds " };

            // 2.Naudojant foreach cikla išspausdinti iš pirmojo projekto pasirinktą masyvą. 
            // Kiekvieną elementą spausdinant i atskirą eilutę.

            foreach (string cardSuit in cardSuits)
            {
                Console.WriteLine(cardSuit);
            }

            // 3. Naudojant foreach cikla išspausdinti kitą iš pirmojo projekto pasirinktą. Grupuoti elementus po 5 per eilute.

            int count = 0;

            foreach (int studentGrade in studentGrades)
            {
                Console.Write($"{studentGrade}, ");
                count++;
                if (count % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}