namespace pair_programming_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Užduotis: Surasti ir atspausdinti pirmąją eilutę, kurioje yra nurodytas žodis.
            //Aprašymas: Sukurkite string tipo masyvą su keliais sakiniais. 
            //Suraskite pirmąją eilutę, kurioje yra nurodytas žodis, ir atspausdinkite ją ekrane.

            string[] sentences = { "As esu sakinys", "2 sakinys", "3 sakinys" };

            Console.WriteLine("Iveskite zodi: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].ToLower().Contains(userInput.Trim().ToLower()))
                {
                    Console.WriteLine(sentences[i]);
                    break;
                }
            }
        }
    }
}