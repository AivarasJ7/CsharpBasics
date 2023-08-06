using System;

namespace csharp34
{
    public class FileMethods
    {
        // Parašykite programą, kuri suskaičiuoja kiek žodžių yra faile.
        // Patarimai:
        // Pradėkite nuo testų.Metodo, kuris nuskaito iš failo duomenis testuoti nereikia per sudėtinga kol kas.nebent patys surasit kaip :)
        // Vienas metodas nuskaito iš failo ir grąžina sąrašą, eilučių. Kitas metodas turi parametrą, 
        // kuriam paduodamas sąrašas eilučių, o metodas suskaičiuoja kiek žodžių yra faile.

        /// <summary>
        /// 1. Nuskaitome failo turinį ir parsinešame jį kaip List<string>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> ReadFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return new List<string>();
            }

            List<string> lines = new List<string>();

            using StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                lines.Add(line);
            }

            return lines;
        }

        /// <summary>
        /// 1. Skaičiuosime kekvieną žodį kol pasibaigs "stream" ir pridėsime žodį prie žodžių kiekio.
        /// 2. null apsauga.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int CountWordsInFile(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path), "(path) negali buti null");
            }

            using StreamReader sr = new StreamReader(path);

            int wordCount = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }

            return wordCount;
        }
    }
}
