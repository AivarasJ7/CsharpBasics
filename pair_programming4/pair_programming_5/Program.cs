namespace pair_programming_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Užduotis: Surasti ir atspausdinti žodžius, kurie yra ilgesni nei nurodytas ilgis.
            //Aprašymas: Sukurkite string tipo masyvą su keliais žodžiais.
            //Suraskite žodžius, kurių ilgis yra didesnis nei nurodytas, ir atspausdinkite juos ekrane.

            string[] words = { "labas", "kepure", "ausine", "pele", "kivis" };

            Console.WriteLine("Iveskite zodzio ilgi: ");

            int wordLengthUserInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Zodziai kurie ilgesni uz jusu nurodyta ilgi: ");

            int longerWordCount = 0;

            foreach (string word in words)
            {
                if (word.Length > wordLengthUserInput)
                {
                    Console.WriteLine(word);
                    longerWordCount++;
                }
            }

            if (longerWordCount == 0)
            {
                Console.WriteLine("Zodziu kurie ilgesni uz jusu nurodyta ilgi nera.");
            }
        }
    }
}