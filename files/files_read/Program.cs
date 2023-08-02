namespace files_read
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = ReadFromFile("data.txt");

            int wordsCount = ProcessFileOnReadingAndCountWords("data.txt", "hola");
        }

        private static List<string> ReadFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return new List<string>();
            }
            
            List<string> lines = new List<string>();

            using StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream) // kol ne failo pabaiga
            { 
                string line = sr.ReadLine();
                lines.Add(line);
            }

            return lines;
        }

        private static int ProcessFileOnReadingAndCountWords(
            string path, 
            string word)
        {
            using StreamReader sr = new StreamReader(path);

            int wordCount = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                if (line.Contains(word))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}