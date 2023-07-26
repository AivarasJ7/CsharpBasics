namespace first_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parašykite programą, kuri paprašytų vartotojo įvesti skaičių. Šis skaičius reiškia jūsų prekių krepšelio dydį. 
            // Tada vartotojas turi įvedinėti prekes. Prekės dedamos į krepšelį. Jeigu prekės pavadinimo ilgis yra ilgesnis, 
            // negu vartotojo įvestas skaičius (prekių krepšelio dydis), tuomet prekė nėra dedama į krepšelį.
            // Užpildžius krepšelį, šį išspausdinkite jūsų pasirinktu formatu. Išspausdinamos prekės ir prekių kiekis krepšelyje. 

            // Kintamojo tipas krepšeliui saugoti gali būti jūsų pasirinktas nesvarbu kuris rinkinys.

            // Užduotį atlikite 3 skirtingais būdais, naudodami 3 skirtingus ciklus. Tie 3 skirtingi ciklai tai krepšeliui užpildyti.
            // Kiekvieną variantą darykite atskirame projekte.Laikas 30 - 40 min.
            // Vertinimas:
            // Vienas variantas ir jokių klaidų: 5 balai.
            // Du variantai ir jokių klaidų: 8 balai
            // Trys variantai ir jokių klaidų: 10 balų.

            Console.WriteLine("Iveskite skaiciu: ");
            int shoppingCartSize = int.Parse(Console.ReadLine());

            List<string> shoppingCartList = new List<string>();

            for (int i = 0; i < shoppingCartSize; i++)
            {
                Console.WriteLine("Iveskite prekes pavadinima:");
                string product = Console.ReadLine();

                if (product.Length <= shoppingCartSize)
                {
                    shoppingCartList.Add(product);
                }
                else
                {
                    Console.WriteLine("Prekes pavadinimas per ilgas, preke nebus dedama i krepseli.");
                }
            }

            Console.WriteLine("Jusu prekiu krepselyje yra:");

            for (int i = 0; i < shoppingCartList.Count; i++)
            {
                Console.WriteLine(shoppingCartList[i]);
            }

            Console.WriteLine($"Prekiu kiekis krepselyje: {shoppingCartList.Count}");
        }
    }
}