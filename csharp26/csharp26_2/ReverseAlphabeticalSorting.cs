namespace csharp26_2
{
    public class ReverseAlphabeticalSorting
    {
        public static void Main(string[] args)
        {
            // Užduotis 2: Išrūšiuoti žodžius prie6inai abėcėlės tvarka. 
            // Metodas: Sukurkite metodą, kuris priima sąrašą žodžių ir grąžina išrūšiuotą sąrašą priešingai abėcėlės tvarkai. 
            // Parašykite testą.

            List<string> words = new List<string>()
            {
                "Namas",
                "Ananasas",
                "Bebras",
                "Laikrodis",
                "Durys"
            };

            Console.WriteLine("Zodziu sarasas: ");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            SortWordsReverseAlphabetical(words);

            Console.WriteLine("Zodziu sarasas po rusiavimo priesingai abeceles tvarkai: ");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static List<string> SortWordsReverseAlphabetical(List<string> words)
        {
            words.Sort();
            words.Reverse();
            return words;
        }

    }
}