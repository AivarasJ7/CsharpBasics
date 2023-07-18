namespace csharp18_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.Parašykite programą, kuri leidžia vartotojui įvesti 10 žodžių į List<string> sąrašą 
            // ir suranda ilgiausią žodį bei atspausdina jį kartu su ilgiu.

            List<string> userWords = new List<string>();

            for (int wordCount = 0; wordCount < 10; wordCount++)
            {
                Console.WriteLine("Iveskite zodi: ");
                string userInput = Console.ReadLine();

                userWords.Add(userInput);
            }

            string longestWord = "";

            foreach (string userWord in userWords)
            {
                if (userWord.Length > longestWord.Length)
                {
                    longestWord = userWord;
                }
            }

            Console.WriteLine($"Ilgiausias zodis: {longestWord} {longestWord.Length}");
        }
    }
}