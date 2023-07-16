namespace csharp17_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Susikurti žodžių sąrašą. Rasti trumpiausią ir ilgiausią žodžius, juos išvesti į ekraną, 
            //prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.

            List<string> wordsList = new List<string>()
            {
                "House",
                "White",
                "Door",
                "Dog",
                "Cat"
            };

            foreach (string word in wordsList)
            {
                Console.Write($"{word} ");
                Console.WriteLine(word.Length);
            }
        }
    }
}